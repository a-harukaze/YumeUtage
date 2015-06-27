using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hp_Mainasubutton : MonoBehaviour {
	
	public Text k_hp_nokori_p;
	
	public Text k_hp_downt_kin;
	public Text k_hp_downt_mag;
	public Text k_hp_downt_bin;
	public Text k_hp_downt_men;
	public Text k_hp_downt_sei;
	
	public Text k_hp_downt;
	static int k_hp_down_hojo;
	static bool k_hpd_ok;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// downdate is called once per frame
	void Update () {
		
	}
	
	// 仮入力ポイントを増やす 仮入力を表示 成長ポイント処理
	public void Kari_HPdown(){
		hp_pupbutton.k_hp_upp--;
		k_hp_downt.text = "" + hp_pupbutton.k_hp_upp;

		//　成長ポイント計算 １ポイント下がった状態で計算

		k_hp_down_hojo = Csute.hero_HP - 101;
		if (k_hp_down_hojo < 0) {
			Csute.hero_HP_kin = 3;
		}else{
			Csute.hero_HP_kin = k_hp_down_hojo/20+3;
		}
		k_hp_down_hojo = Csute.hero_HP - 101;
		if (k_hp_down_hojo < 0) {
			Csute.hero_HP_mag = 1;
		}else{
			Csute.hero_HP_mag = k_hp_down_hojo/30+1;
		}
		k_hp_down_hojo = Csute.hero_HP - 101;
		if (k_hp_down_hojo < 0) {
			Csute.hero_HP_bin = 1;
		}else{
			Csute.hero_HP_bin = k_hp_down_hojo/30+1;
		}
		k_hp_down_hojo = Csute.hero_HP - 101;
		if (k_hp_down_hojo < 0) {
			Csute.hero_HP_men = 1;
		}else{
			Csute.hero_HP_men = k_hp_down_hojo/30+1;
		}
		k_hp_down_hojo = Csute.hero_HP - 101;
		if (k_hp_down_hojo < 0) {
			Csute.hero_HP_sei = 1;
		}else{
			Csute.hero_HP_sei = k_hp_down_hojo/30+1;
		}

		Csute.hero_Kin += Csute.hero_HP_kin;
		Csute.hero_Mag += Csute.hero_HP_mag;
		Csute.hero_Bin += Csute.hero_HP_bin;
		Csute.hero_Men += Csute.hero_HP_men;
		Csute.hero_Sei += Csute.hero_HP_sei;

	}
	
	public void MhpOKbuttonyobu(){

		// 増減可能判定
		if (hp_pupbutton.k_hp_upp<=0) {
			k_hpd_ok = false;
		} else {
			k_hpd_ok = true;
		}
		
		if (k_hpd_ok == false) {
			this.gameObject.SetActive (false);
		}
	}
	
	// マイナスＮＧボタン呼び出し
	public void MhpNGbuttonyobu(){
		if (k_hpd_ok == false) {
			this.gameObject.SetActive (true);
		}
	}
	
	// 残りポイント表示
	public void K_HP_NokoriP(){
		k_hp_nokori_p.text = "残筋：" + Csute.hero_Kin + "残敏：" + Csute.hero_Bin + "残心："+ Csute.hero_Men +"\n残魔："+ Csute.hero_Mag +"残器："+ Csute.hero_Sei ;
	}
	
	// 成長ポイント再表示
	public void Y_Kari_hp_kin_u(){
		k_hp_downt_kin.text = "筋：" + Csute.hero_HP_kin ;
	}
	public void Y_Kari_hp_mag_u(){
		k_hp_downt_mag.text = "魔：" + Csute.hero_HP_mag ;
	}
	public void Y_Kari_hp_bin_u(){
		k_hp_downt_bin.text = "敏：" + Csute.hero_HP_bin ;
	}
	public void Y_Kari_hp_men_u(){
		k_hp_downt_men.text = "心：" + Csute.hero_HP_men ;
	}
	public void Y_Kari_hp_sei_u(){
		k_hp_downt_sei.text = "器：" + Csute.hero_HP_sei ;
	}
	
	// プラスボタン用意
	public void PhpOKbuton(){
		this.gameObject.SetActive (true);
	}
	
	// プラスＮＧボタン消す
	public void PhpNPbuton(){
		this.gameObject.SetActive (false);
	}
}