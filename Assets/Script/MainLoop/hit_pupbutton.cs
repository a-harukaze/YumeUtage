using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hit_pupbutton : MonoBehaviour {
	public static int k_hit_upp;
	public Text k_hit_nokori_p;

	public Text k_hit_upt_kin;
	public Text k_hit_upt_mag;
	public Text k_hit_upt_bin;
	public Text k_hit_upt_men;
	public Text k_hit_upt_sei;

	public Text k_hit_upt;
	static int k_hit_up_hojo;
	static bool k_hitu_ok;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// 仮入力ポイントを増やす 仮入力を表示 成長ポイント処理
	public void Kari_HitUP(){
		k_hit_upp++;
		k_hit_upt.text = "" + k_hit_upp;

		Csute.hero_Kin -= Csute.hero_Hit_kin;
		Csute.hero_Mag -= Csute.hero_Hit_mag;
		Csute.hero_Bin -= Csute.hero_Hit_bin;
		Csute.hero_Men -= Csute.hero_Hit_men;
		Csute.hero_Sei -= Csute.hero_Hit_sei;
	}
	
	// プラスＯＫボタン消去
	public void PKhitOKbuttonyobu(){
		// 増減可能判定
		if (Csute.hero_Kin >= Csute.hero_Hit_kin && Csute.hero_Mag >= Csute.hero_Hit_mag && Csute.hero_Bin >= Csute.hero_Hit_bin && Csute.hero_Men >= Csute.hero_Hit_men && Csute.hero_Sei >= Csute.hero_Hit_sei) {
			k_hitu_ok = true;
		} else {
			k_hitu_ok = false;
		}

		if (k_hitu_ok == false) {
			this.gameObject.SetActive (false);
		}else if(k_hitu_ok == true){
			this.gameObject.SetActive (true);
		}
	}
	
	// プラスＮＧボタン呼び出し
	public void PKhitNGbuttonyobu(){
		if (k_hitu_ok == false) {
			this.gameObject.SetActive (true);
		}else if(k_hitu_ok == true){
			this.gameObject.SetActive (false);
		}
	}

	// 残りポイント表示
	public void K_Hit_NokoriP(){
		k_hit_nokori_p.text = "残筋：" + Csute.hero_Kin + "残敏：" + Csute.hero_Bin + "残心："+ Csute.hero_Men +"\n残魔："+ Csute.hero_Mag +"残器："+ Csute.hero_Sei ;
	}

	// 成長ポイント再表示
	public void Y_Kari_hit_kin_u(){
		k_hit_upt_kin.text = "筋：" + Csute.hero_Hit_kin ;
	}
	public void Y_Kari_hit_mag_u(){
		k_hit_upt_mag.text = "魔：" + Csute.hero_Hit_mag ;
	}
	public void Y_Kari_hit_bin_u(){
		k_hit_upt_bin.text = "敏：" + Csute.hero_Hit_bin ;
	}
	public void Y_Kari_hit_men_u(){
		k_hit_upt_men.text = "心：" + Csute.hero_Hit_men ;
	}
	public void Y_Kari_hit_sei_u(){
		k_hit_upt_sei.text = "器：" + Csute.hero_Hit_sei ;
	}

	// マイナスボタン用意
	public void PMKhitOKbuton(){
			this.gameObject.SetActive (true);
	}

	// マイナスＮＧボタン消す
	public void PMKhitNPbuton(){
			this.gameObject.SetActive (false);
	}
}
