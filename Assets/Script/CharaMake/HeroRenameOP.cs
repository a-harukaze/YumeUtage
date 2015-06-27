using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HeroRenameOP : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// インプットフィールド呼ぶ
	public void NinputF(){
		this.gameObject.SetActive (true);
	}

	// 名前確認オブジェクト非表示
	public void NKakuO(){
		this.gameObject.SetActive (false);
	}

}
