using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NKakuOK : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}

	// 師匠選択画面呼び出し
	public void T_open(){
		this.gameObject.SetActive (true);
	}
	
	// 名前確認終了
	public void Nkaku_close(){
		this.gameObject.SetActive (false);
	}
}
