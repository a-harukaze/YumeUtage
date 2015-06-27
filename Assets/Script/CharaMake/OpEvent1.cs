using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OpEvent1 : MonoBehaviour {
	public Text opevtext;
	public static int mid = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	//マウスクリック判定・
	void Update () {
	}

	//文章ウィンドウ
	public void Optext() {
		mid ++;
		if (mid == 1) {
			opevtext.text = "まずは観光産業を作って、" +
				"奇跡の復興を遂げるというシナリオを" +
					"復興プランにした。";
		} else if (mid == 2) {
			opevtext.text = "復興プランでは" +
				"まずバトルシミュレータという装置を使った" +
					"仮想空間のコロシアムを用意する。";
		} else if (mid == 3) {
			opevtext.text= "そして３年間で選手を育成する。";	
		} else if (mid == 4) {
			opevtext.text = "他に仕事の少ないこの国で、" +
				"あなたは強化選手として扉をたたいた。";
		}
	}

	// オープニング１非表示
	public void Op1Del(){
		if (mid == 5) {
			this.gameObject.SetActive (false);
		}
	}

	// 主人公名前入力へ
	public void NIField(){
		if (mid == 5) {
			this.gameObject.SetActive (true);
		}
	}
}
