using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class agi_pupbutton : MonoBehaviour {
	public static int k_agi_upp;
	public Text k_agi_nokori_p;
	
	public Text k_agi_upt_kin;
	public Text k_agi_upt_mag;
	public Text k_agi_upt_bin;
	public Text k_agi_upt_men;
	public Text k_agi_upt_sei;
	
	public Text k_agi_upt;
	static int k_agi_up_hojo;
	static bool k_agiu_ok;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	// 仮入力ポイントを増やす 仮入力を表示 成長ポイント処理
	public void Kari_agiUP(){
		k_agi_upp++;
		k_agi_upt.text = "" + k_agi_upp;
		
		Csute.hero_Kin -= Csute.hero_Agi_kin;
		Csute.hero_Mag -= Csute.hero_Agi_mag;
		Csute.hero_Bin -= Csute.hero_Agi_bin;
		Csute.hero_Men -= Csute.hero_Agi_men;
		Csute.hero_Sei -= Csute.hero_Agi_sei;
	}
	
	// プラスＯＫボタン消去
	public void PKAgiOKbuttonyobu(){
		// 増減可能判定
		if (Csute.hero_Kin >= Csute.hero_Agi_kin && Csute.hero_Mag >= Csute.hero_Agi_mag && Csute.hero_Bin >= Csute.hero_Agi_bin && Csute.hero_Men >= Csute.hero_Agi_men && Csute.hero_Sei >= Csute.hero_Agi_sei) {
			k_agiu_ok = true;
		} else {
			k_agiu_ok = false;
		}
		
		if (k_agiu_ok == false) {
			this.gameObject.SetActive (false);
		}else if(k_agiu_ok == true){
			this.gameObject.SetActive (true);
		}
	}
	
	// プラスＮＧボタン呼び出し
	public void PKAgiNGbuttonyobu(){
		if (k_agiu_ok == false) {
			this.gameObject.SetActive (true);
		}else if(k_agiu_ok == true){
			this.gameObject.SetActive (false);
		}
	}
	
	// 残りポイント表示
	public void K_Agi_NokoriP(){
		k_agi_nokori_p.text = "残筋：" + Csute.hero_Kin + "残敏：" + Csute.hero_Bin + "残心："+ Csute.hero_Men +"\n残魔："+ Csute.hero_Mag +"残器："+ Csute.hero_Sei ;
	}
	
	// 成長ポイント再表示
	public void Y_Kari_agi_kin_u(){
		k_agi_upt_kin.text = "筋：" + Csute.hero_Agi_kin ;
	}
	public void Y_Kari_agi_mag_u(){
		k_agi_upt_mag.text = "魔：" + Csute.hero_Agi_mag ;
	}
	public void Y_Kari_agi_bin_u(){
		k_agi_upt_bin.text = "敏：" + Csute.hero_Agi_bin ;
	}
	public void Y_Kari_agi_men_u(){
		k_agi_upt_men.text = "心：" + Csute.hero_Agi_men ;
	}
	public void Y_Kari_agi_sei_u(){
		k_agi_upt_sei.text = "器：" + Csute.hero_Agi_sei ;
	}
	
	// マイナスボタン用意
	public void PMKagiOKbuton(){
		this.gameObject.SetActive (true);
	}
	
	// マイナスＮＧボタン消す
	public void PMKagiNPbuton(){
		this.gameObject.SetActive (false);
	}
}
