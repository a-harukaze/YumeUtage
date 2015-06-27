using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class agi_Mainasubutton : MonoBehaviour {
	
	public Text k_agi_nokori_p;
	
	public Text k_agi_downt_kin;
	public Text k_agi_downt_mag;
	public Text k_agi_downt_bin;
	public Text k_agi_downt_men;
	public Text k_agi_downt_sei;
	
	public Text k_agi_downt;
	static int k_agi_down_hojo;
	static bool k_agid_ok;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// downdate is called once per frame
	void Update () {
		
	}
	
	// 仮入力ポイントを増やす 仮入力を表示 成長ポイント処理
	public void Kari_Agidown(){
		agi_pupbutton.k_agi_upp--;
		k_agi_downt.text = "" + agi_pupbutton.k_agi_upp;
		
		//　成長ポイント計算 １ポイント下がった状態で計算
		
		k_agi_down_hojo = Csute.hero_Agi - 101;
		if (k_agi_down_hojo < 0) {
			Csute.hero_Agi_kin = 3;
		}else{
			Csute.hero_Agi_kin = k_agi_down_hojo/20+1;
		}
		k_agi_down_hojo = Csute.hero_Agi - 101;
		if (k_agi_down_hojo < 0) {
			Csute.hero_Agi_mag = 1;
		}else{
			Csute.hero_Agi_mag = k_agi_down_hojo/20+2;
		}
		k_agi_down_hojo = Csute.hero_Agi - 101;
		if (k_agi_down_hojo < 0) {
			Csute.hero_Agi_bin = 1;
		}else{
			Csute.hero_Agi_bin = k_agi_down_hojo/15+3;
		}
		k_agi_down_hojo = Csute.hero_Agi - 101;
		if (k_agi_down_hojo < 0) {
			Csute.hero_Agi_men = 1;
		}else{
			Csute.hero_Agi_men = k_agi_down_hojo/20+2;
		}
		k_agi_down_hojo = Csute.hero_Agi - 101;
		if (k_agi_down_hojo < 0) {
			Csute.hero_Agi_sei = 1;
		}else{
			Csute.hero_Agi_sei = k_agi_down_hojo/20+2;
		}
		
		Csute.hero_Kin += Csute.hero_Agi_kin;
		Csute.hero_Mag += Csute.hero_Agi_mag;
		Csute.hero_Bin += Csute.hero_Agi_bin;
		Csute.hero_Men += Csute.hero_Agi_men;
		Csute.hero_Sei += Csute.hero_Agi_sei;
	}
	
	// ＯＫボタン消去
	public void MagiOKbuttonyobu(){

		// 増減可能判定
		if (agi_pupbutton.k_agi_upp<=0) {
			k_agid_ok = false;
		} else {
			k_agid_ok = true;
		}
		
		if (k_agid_ok == false) {
			this.gameObject.SetActive (false);
		}
	}
	
	// マイナスＮＧボタン呼び出し
	public void MagiNGbuttonyobu(){
		if (k_agid_ok == false) {
			this.gameObject.SetActive (true);
		}
	}
	
	// 残りポイント表示
	public void K_Agi_NokoriP(){
		k_agi_nokori_p.text = "残筋：" + Csute.hero_Kin + "残敏：" + Csute.hero_Bin + "残心："+ Csute.hero_Men +"\n残魔："+ Csute.hero_Mag +"残器："+ Csute.hero_Sei ;
	}
	
	// 成長ポイント再表示
	public void Y_Kari_agi_kin_u(){
		k_agi_downt_kin.text = "筋：" + Csute.hero_Agi_kin ;
	}
	public void Y_Kari_agi_mag_u(){
		k_agi_downt_mag.text = "魔：" + Csute.hero_Agi_mag ;
	}
	public void Y_Kari_agi_bin_u(){
		k_agi_downt_bin.text = "敏：" + Csute.hero_Agi_bin ;
	}
	public void Y_Kari_agi_men_u(){
		k_agi_downt_men.text = "心：" + Csute.hero_Agi_men ;
	}
	public void Y_Kari_agi_sei_u(){
		k_agi_downt_sei.text = "器：" + Csute.hero_Agi_sei ;
	}
	
	// プラスボタン用意
	public void PagiOKbuton(){
		this.gameObject.SetActive (true);
	}
	
	// プラスＮＧボタン消す
	public void PagiNPbuton(){
		this.gameObject.SetActive (false);
	}
}