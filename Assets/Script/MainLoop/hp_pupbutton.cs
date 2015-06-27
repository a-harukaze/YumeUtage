using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hp_pupbutton : MonoBehaviour {

	public static int k_hp_upp;
	public Text k_hp_nokori_p;

	public Text k_hp_upt_kin;
	public Text k_hp_upt_mag;
	public Text k_hp_upt_bin;
	public Text k_hp_upt_men;
	public Text k_hp_upt_sei;

	public Text k_hp_upt;
	static int k_hp_up_hojo;
	static bool k_hpu_ok;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// 仮入力ポイントを増やす 仮入力を表示 成長ポイント処理
	public void Kari_HPUP(){
		k_hp_upp++;
		k_hp_upt.text = "" + k_hp_upp;

		Csute.hero_Kin -= Csute.hero_HP_kin;
		Csute.hero_Mag -= Csute.hero_HP_mag;
		Csute.hero_Bin -= Csute.hero_HP_bin;
		Csute.hero_Men -= Csute.hero_HP_men;
		Csute.hero_Sei -= Csute.hero_HP_sei;
	}
	
	// プラスＯＫボタン消去
	public void PKhpOKbuttonyobu(){

		// 増減可能判定
		if (Csute.hero_Kin >= Csute.hero_HP_kin && Csute.hero_Mag >= Csute.hero_HP_mag && Csute.hero_Bin >= Csute.hero_HP_bin && Csute.hero_Men >= Csute.hero_HP_men && Csute.hero_Sei >= Csute.hero_HP_sei) {
			k_hpu_ok = true;
		} else {
			k_hpu_ok = false;
		}

		if (k_hpu_ok == false) {
			this.gameObject.SetActive (false);
		}else if(k_hpu_ok == true){
			this.gameObject.SetActive (true);
		}
	}
	
	// プラスＮＧボタン呼び出し
	public void PKhpNGbuttonyobu(){
		if (k_hpu_ok == false) {
			this.gameObject.SetActive (true);
		}else if(k_hpu_ok == true){
			this.gameObject.SetActive (false);
		}
	}

	// 残りポイント表示
	public void K_HP_NokoriP(){
		k_hp_nokori_p.text = "残筋：" + Csute.hero_Kin + "残敏：" + Csute.hero_Bin + "残心："+ Csute.hero_Men +"\n残魔："+ Csute.hero_Mag +"残器："+ Csute.hero_Sei ;
	}

	// 成長ポイント再表示
	public void Y_Kari_hp_kin_u(){
		k_hp_upt_kin.text = "筋：" + Csute.hero_HP_kin ;
	}
	public void Y_Kari_hp_mag_u(){
		k_hp_upt_mag.text = "魔：" + Csute.hero_HP_mag ;
	}
	public void Y_Kari_hp_bin_u(){
		k_hp_upt_bin.text = "敏：" + Csute.hero_HP_bin ;
	}
	public void Y_Kari_hp_men_u(){
		k_hp_upt_men.text = "心：" + Csute.hero_HP_men ;
	}
	public void Y_Kari_hp_sei_u(){
		k_hp_upt_sei.text = "器：" + Csute.hero_HP_sei ;
	}

	// マイナスボタン用意
	public void PMKhpOKbuton(){
			this.gameObject.SetActive (true);
	}

	// マイナスＮＧボタン消す
	public void PMKhpNPbuton(){
			this.gameObject.SetActive (false);
	}
}
