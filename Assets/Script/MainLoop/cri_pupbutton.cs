using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cri_pupbutton : MonoBehaviour {
	public static int k_cri_upp;
	public Text k_cri_nokori_p;
	
	public Text k_cri_upt_kin;
	public Text k_cri_upt_mag;
	public Text k_cri_upt_bin;
	public Text k_cri_upt_men;
	public Text k_cri_upt_sei;
	
	public Text k_cri_upt;
	static int k_cri_up_hojo;
	static bool k_criu_ok;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	// 仮入力ポイントを増やす 仮入力を表示 成長ポイント処理
	public void Kari_CritUP(){
		k_cri_upp++;
		k_cri_upt.text = "" + k_cri_upp;
		
		Csute.hero_Kin -= Csute.hero_Crit_kin;
		Csute.hero_Mag -= Csute.hero_Crit_mag;
		Csute.hero_Bin -= Csute.hero_Crit_bin;
		Csute.hero_Men -= Csute.hero_Crit_men;
		Csute.hero_Sei -= Csute.hero_Crit_sei;
	}
	
	// プラスＯＫボタン消去
	public void PKcriOKbuttonyobu(){
		// 増減可能判定
		if (Csute.hero_Kin >= Csute.hero_Crit_kin && Csute.hero_Mag >= Csute.hero_Crit_mag && Csute.hero_Bin >= Csute.hero_Crit_bin && Csute.hero_Men >= Csute.hero_Crit_men && Csute.hero_Sei >= Csute.hero_Crit_sei) {
			k_criu_ok = true;
		} else {
			k_criu_ok = false;
		}
		
		if (k_criu_ok == false) {
			this.gameObject.SetActive (false);
		}else if(k_criu_ok == true){
			this.gameObject.SetActive (true);
		}
	}
	
	// プラスＮＧボタン呼び出し
	public void PKcriNGbuttonyobu(){
		if (k_criu_ok == false) {
			this.gameObject.SetActive (true);
		}else if(k_criu_ok == true){
			this.gameObject.SetActive (false);
		}
	}
	
	// 残りポイント表示
	public void K_Crit_NokoriP(){
		k_cri_nokori_p.text = "残筋：" + Csute.hero_Kin + "残敏：" + Csute.hero_Bin + "残心："+ Csute.hero_Men +"\n残魔："+ Csute.hero_Mag +"残器："+ Csute.hero_Sei ;
	}
	
	// 成長ポイント再表示
	public void Y_Kari_cri_kin_u(){
		k_cri_upt_kin.text = "筋：" + Csute.hero_Crit_kin ;
	}
	public void Y_Kari_cri_mag_u(){
		k_cri_upt_mag.text = "魔：" + Csute.hero_Crit_mag ;
	}
	public void Y_Kari_cri_bin_u(){
		k_cri_upt_bin.text = "敏：" + Csute.hero_Crit_bin ;
	}
	public void Y_Kari_cri_men_u(){
		k_cri_upt_men.text = "心：" + Csute.hero_Crit_men ;
	}
	public void Y_Kari_cri_sei_u(){
		k_cri_upt_sei.text = "器：" + Csute.hero_Crit_sei ;
	}
	
	// マイナスボタン用意
	public void PMKcriOKbuton(){
		this.gameObject.SetActive (true);
	}
	
	// マイナスＮＧボタン消す
	public void PMKcriNPbuton(){
		this.gameObject.SetActive (false);
	}
}
