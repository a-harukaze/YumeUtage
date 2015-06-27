using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GoNextHero : MonoBehaviour {
	static int kari_t_kin_U;
	static int kari_t_mag_U;
	static int kari_t_bin_U;
	static int kari_t_men_U;
	static int kari_t_sei_U;

	static int tidin;
	static int iee;
	static bool ief;

	public Text eventtext;
	public Text last_text;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Last_text(){
		if(ief == false){
			last_text.text = "Ｔｈａｎｋ　Ｙｏｕ\nＦｏｒ　Ｐｌａｙｉｎｇ！！\n\n制作者：春風輝\n\nスペシャルサンクス\n制作ツール：ＵＮＩＴＹ\n素材サイト様\n効果音：ザ・マッチメイカァズ2nd様\n音楽・効果音：魔王魂\n背景：ぐったりにゃんこ様\n\nそして最後に\nプレイしてくれたあなた";
			ief = true;
		}
	}

	// 育てたキャラを師匠にする
	// 師匠能力決定
	// １６人以上居たら古い師匠から消していく
	public void new_teacher(){
		if (ief == true){
		if(Csute.t_kazu < 6){
			Csute.t_kazu ++;
		}else if (Csute.t_kazu==6){
			Csute.t_kazu =6;
		}

		kari_t_kin_U = ((Csute.hero_HP-70)/50)+((Csute.hero_Kougeki-20)/12)+((Csute.hero_Bougyo-10)/20)+((Csute.hero_Hit-70)/25)+(Csute.hero_Kaihi/25)+(Csute.hero_Crit/20)+((Csute.hero_Agi-70)/40)+Csute.hero_lank;
		kari_t_mag_U = ((Csute.hero_HP-70)/70)+((Csute.hero_Kougeki-20)/20)+((Csute.hero_Bougyo-10)/20)+((Csute.hero_Hit-70)/20)+(Csute.hero_Kaihi/20)+(Csute.hero_Crit/16)+((Csute.hero_Agi-70)/30)+Csute.hero_lank;
		kari_t_bin_U = ((Csute.hero_HP-70)/80)+((Csute.hero_Kougeki-20)/20)+((Csute.hero_Bougyo-10)/20)+((Csute.hero_Hit-70)/16)+(Csute.hero_Kaihi/16)+(Csute.hero_Crit/12)+((Csute.hero_Agi-70)/20)+Csute.hero_lank;
		kari_t_men_U = ((Csute.hero_HP-70)/65)+((Csute.hero_Kougeki-20)/20)+((Csute.hero_Bougyo-10)/20)+((Csute.hero_Hit-70)/20)+(Csute.hero_Kaihi/20)+(Csute.hero_Crit/16)+((Csute.hero_Agi-70)/30)+Csute.hero_lank;
		kari_t_sei_U = ((Csute.hero_HP-70)/80)+((Csute.hero_Kougeki-20)/25)+((Csute.hero_Bougyo-10)/25)+((Csute.hero_Hit-70)/12)+(Csute.hero_Kaihi/14)+(Csute.hero_Crit/14)+((Csute.hero_Agi-70)/30)+Csute.hero_lank;

		for(iee = Csute.t_kazu; iee>=0 ; iee--){
			if( iee == 0){
					Csute.t_name[iee] =Csute.hero_name;
					Csute.t_Kin_U[iee] =kari_t_kin_U;
					Csute.t_Mag_U[iee] =kari_t_mag_U;
					Csute.t_Bin_U[iee] =kari_t_bin_U;
					Csute.t_Men_U[iee] =kari_t_men_U;
					Csute.t_Sei_U[iee] =kari_t_sei_U;
			}else if(iee > 1){
					Csute.t_name[iee]  = Csute.t_name[iee-1];
					Csute.t_Kin_U[iee] =Csute.t_Kin_U[iee-1];
					Csute.t_Mag_U[iee] =Csute.t_Mag_U[iee-1];
					Csute.t_Bin_U[iee] =Csute.t_Bin_U[iee-1];
					Csute.t_Men_U[iee] =Csute.t_Men_U[iee-1];
					Csute.t_Sei_U[iee] =Csute.t_Sei_U[iee-1];
			}
		}
		}
	}

	// ＯＰへ
	public void ED_End(){
		if(ief == true){
			Csute.nen = 0;
		this.gameObject.SetActive(false);
		}
	}

	public void Next_hero_Make(){
		if(ief == true){
		this.gameObject.SetActive(true);
		}
	}

	public void Opning2(){
		eventtext.text = "AS3489年、銀河にある１つの国で" +
			"内戦が終わった。" ;
	}
}
