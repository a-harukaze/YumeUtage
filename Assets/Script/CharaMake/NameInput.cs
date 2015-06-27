using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NameInput : MonoBehaviour {
	public Text nameInput;
	public InputField nInput;

	// Use this for initialization
	void Start () {
		OpEvent1.mid = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// 名前確認オブジェクト起動
	public void NKakuKidou(){
		this.gameObject.SetActive (true);
	}

	// 名前確認テキスト
	public void NameKaku(){
		if (nInput.text == "") {
			Csute.hero_name = "ユウシャ";
		} else {
			Csute.hero_name = nInput.text;
		}
		nameInput.text = "あなたの名前は" +
			"<b><Color=yellow>" + Csute.hero_name + "</color></b>" + "になります。" +
				"いいですか？";
	}
	
	// インプットフィールド消去
	public void NIFDel(){
		this.gameObject.SetActive (false);
	}
}
