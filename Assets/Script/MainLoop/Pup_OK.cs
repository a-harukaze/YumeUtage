using UnityEngine;
using System.Collections;

public class Pup_OK : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// 成長決定
	public void UP_Kettei(){
		Csute.hero_HP += hp_pupbutton.k_hp_upp;
		Csute.hero_Kougeki += kou_pupbutton.k_kou_upp;
		Csute.hero_Bougyo += bou_pupbutton.k_bou_upp;
		Csute.hero_Hit += hit_pupbutton.k_hit_upp;
		Csute.hero_Kaihi += kai_pupbutton.k_kai_upp;
		Csute.hero_Crit += cri_pupbutton.k_cri_upp;
		Csute.hero_Agi += agi_pupbutton.k_agi_upp;

		// 戦闘力再計算
		Csute.hero_sentouP = Csute.hero_HP;
		Csute.hero_sentouP += Csute.hero_Kougeki;
		Csute.hero_sentouP += Csute.hero_Bougyo;
		Csute.hero_sentouP += Csute.hero_Hit;
		Csute.hero_sentouP += Csute.hero_Kaihi;
		Csute.hero_sentouP += Csute.hero_Crit;
		Csute.hero_sentouP += Csute.hero_Agi;
	}

	//育成画面戻る
	public void IMON(){
		this.gameObject.SetActive (true);
	}
	
	//成長画面消す
	public void PUPPG_OFF(){
		this.gameObject.SetActive (false);
	}
}
