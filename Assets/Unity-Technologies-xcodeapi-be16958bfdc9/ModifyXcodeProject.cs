using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.iOS.Xcode; // ←さっきいれたXcodeAPI
using System.Collections;
using System.IO;
public class ModifyXcodeProject : MonoBehaviour {

		
		// ちょっとしたユーティリティ関数（http://goo.gl/fzYig8を参考）
		internal static void CopyAndReplaceDirectory(string srcPath, string dstPath)
		{
			if (Directory.Exists(dstPath))
				Directory.Delete(dstPath);
			if (File.Exists(dstPath))
				File.Delete(dstPath);
			
			Directory.CreateDirectory(dstPath);
			
			foreach (var file in Directory.GetFiles(srcPath))
				File.Copy(file, Path.Combine(dstPath, Path.GetFileName(file)));
			
			foreach (var dir in Directory.GetDirectories(srcPath))
				CopyAndReplaceDirectory(dir, Path.Combine(dstPath, Path.GetFileName(dir)));
		}
		
		[PostProcessBuild]
		public static void OnPostprocessBuild(BuildTarget buildTarget, string path)
		{
			if (buildTarget == BuildTarget.iOS)
			{
				string projPath = PBXProject.GetPBXProjectPath(path);
				PBXProject proj = new PBXProject();
				
				proj.ReadFromString(File.ReadAllText(projPath));
				string target = proj.TargetGuidByName("Unity-iPhone");
				
				// システムのフレームワークを追加
				proj.AddFrameworkToProject(target, "AssetsLibrary.framework", false);
				
				// 自前のフレームワークを追加
				CopyAndReplaceDirectory("Assets/Lib/mylib.framework", Path.Combine(path, "Frameworks/mylib.framework"));
				proj.AddFileToBuild(target, proj.AddFile("Frameworks/mylib.framework", "Frameworks/mylib.framework", PBXSourceTree.Source));
				
				// ファイルを追加
				var fileName = "my_file.xml";
				var filePath = Path.Combine("Assets/Lib", fileName);
				File.Copy(filePath, Path.Combine(path, fileName));
				proj.AddFileToBuild(target, proj.AddFile(fileName, fileName, PBXSourceTree.Source));
				
				// Yosemiteでipaが書き出せないエラーに対応するための設定
				proj.SetBuildProperty(target, "CODE_SIGN_RESOURCE_RULES_PATH", "$(SDKROOT)/ResourceRules.plist");
				
				// フレームワークの検索パスを設定・追加
				proj.SetBuildProperty(target, "FRAMEWORK_SEARCH_PATHS", "$(inherited)");
				proj.AddBuildProperty(target, "FRAMEWORK_SEARCH_PATHS", "$(PROJECT_DIR)/Frameworks");
				
				// 書き出し
				File.WriteAllText(projPath, proj.WriteToString());
			}
		}
	}