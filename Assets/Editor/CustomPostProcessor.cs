using UnityEngine;
using System;
using System.IO;
using System.Xml;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.XCodeEditor;
using MiniJSON;

/// <summary>
/// Unityのビルド後に実行する処理（XCodeのプロジェクト設定など）
/// </summary>
public static class CustomPostProcessor
{
	/// <summary>
	/// post process build event.
	/// </summary>
	/// <param name="target">Target（iPhone/Androidなど）</param>
	/// <param name="path">出力先のパス（ビルド時に指定するパス）</param>
	[PostProcessBuild (100)]
	public static void OnPostProcessBuild (BuildTarget target, string path)
	{
		if (target == BuildTarget.iOS) {
			PostProcessBuild_iOS (path);
		}
	}
	
	/// <summary>
	/// iOSのビルド設定自動化処理
	/// </summary>
	/// <param name="path">出力先のパス（ビルド時に指定するパス）</param>
	private static void PostProcessBuild_iOS (string path)
	{
		// XCode プロジェクトファイルの設定をする
		CreateModFile (path);
		ProcessXCodeProject (path);
	}
	
	/// <summary>
	/// Mod ファイルの作成
	/// </summary>
	/// <param name="path">出力先のパス（ビルド時に指定するパス）</param>
	private static void CreateModFile (string path)
	{
		Dictionary<string, object> mod = new Dictionary<string, object> ();
		
		List<string> patches = new List<string> ();
		List<string> librarysearchpaths = new List<string> ();
		List<string> folders = new List<string> ();
		List<string> excludes = new List<string> ();
		
		// libs
		List<string> libs = new List<string> ();
		
		// フレームワークサーチパス
		List<string> frameworksearchpaths = new List<string> ();
		
		// フレームワーク
		List<string> frameworks = new List<string> ();
		frameworks.Add ("QuartzCore.framework");
		frameworks.Add ("CoreImage.framework:weak");
		
		// files
		List<string> files = new List<string> ();
		
		// headerpaths
		List<string> headerpaths = new List<string> ();
		
		// ビルド設定
		Dictionary<string,List<string>> buildSettings = new Dictionary<string,List<string>> ();
		List<string> otherLinkerFlags = new List<string> ();
		otherLinkerFlags.Add ("-ObjC");
		buildSettings.Add ("OTHER_LDFLAGS", otherLinkerFlags);
		
		mod.Add ("group", "");
		mod.Add ("patches", patches);
		mod.Add ("libs", libs);
		mod.Add ("librarysearchpaths", librarysearchpaths);
		mod.Add ("frameworksearchpaths", frameworksearchpaths);
		mod.Add ("frameworks", frameworks);
		mod.Add ("headerpaths", headerpaths);
		mod.Add ("files", files);
		mod.Add ("folders", folders);
		mod.Add ("excludes", excludes);
		mod.Add ("buildSettings", buildSettings);
		
		// mod から projmods ファイルを生成する
		string jsonMod = Json.Serialize (mod);
		
		string file = System.IO.Path.Combine (path, "CustomXCode.projmods");
		
		if (File.Exists (file)) {
			File.Delete (file);
		}
		
		using (StreamWriter streamWriter = File.CreateText (file)) {
			streamWriter.Write (jsonMod);
		}
	}
	
	/// <summary>
	/// projmods ファイルの設定値を XCode プロジェクト設定へ反映する
	/// </summary>
	/// <param name="path">出力先のパス（ビルド時に指定するパス）</param>
	private static void ProcessXCodeProject (string path)
	{
		XCProject project = new XCProject (path);
		
		string[] files = System.IO.Directory.GetFiles (path, "*.projmods", System.IO.SearchOption.AllDirectories);
		
		foreach (string file in files) {
			project.ApplyMod ( System.IO.Path.Combine (Application.dataPath, file));
		}
		
		project.Save ();
	}
}
