using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bou_Mainasubutton : MonoBehaviour {
	
	public Text k_bou_nokori_p;
	
	public Text k_bou_downt_kin;
	public Text k_bou_downt_mag;
	public Text k_bou_downt_bin;
	public Text k_bou_downt_men;
	public Text k_bou_downt_sei;
	
	public Text k_bou_downt;
	static int k_bou_down_hojo;
	static bool k_boud_ok;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// downdate is called once per frame
	void Update () {
		
	}
	
	// 仮入力ポイントを増やす 仮入力を表示 成長ポイント処理
	public void Kari_Bougyodown(){
		bou_pupbutton.k_bou_upp--;
		k_bou_downt.text = "" + bou_pupbutton.k_bou_upp;
		
		//　成長ポイント計算 １ポイント下がった状態で計算
		
		k_bou_down_hojo = Csute.hero_Bougyo - 11;
		if (k_bou_down_hojo < 0) {
			Csute.hero_Bougyo_kin = 3;
		}else{
			Csute.hero_Bougyo_kin = k_bou_down_hojo/10+3;
		}
		k_bou_down_hojo = Csute.hero_Bougyo - 16;
		if (k_bou_down_hojo < 0) {
			Csute.hero_Bougyo_mag = 1;
		}else{
			Csute.hero_Bougyo_mag = k_bou_down_hojo/20+1;
		}
		k_bou_down_hojo = Csute.hero_Bougyo - 11;
		if (k_bou_down_hojo < 0) {
			Csute.hero_Bougyo_bin = 3;
		}else{
			Csute.hero_Bougyo_bin = k_bou_down_hojo/10+3;
		}
		k_bou_down_hojo = Csute.hero_Bougyo - 16;
		if (k_bou_down_hojo < 0) {
			Csute.hero_Bougyo_men = 1;
		}else{
			Csute.hero_Bougyo_men = k_bou_down_hojo/20+1;
		}
		k_bou_down_hojo = Csute.hero_Bougyo - 16;
		if (k_bou_down_hojo < 0) {
			Csute.hero_Bougyo_sei = 1;
		}else{
			Csute.hero_Bougyo_sei = k_bou_down_hojo/20+1;
		}
		
		Csute.hero_Kin += Csute.hero_Bougyo_kin;
		Csute.hero_Mag += Csute.hero_Bougyo_mag;
		Csute.hero_Bin += Csute.hero_Bougyo_bin;
		Csute.hero_Men += Csute.hero_Bougyo_men;
		Csute.hero_Sei += Csute.hero_Bougyo_sei;
	}
	
	// ＯＫボタン消去
	public void MbouOKbuttonyobu(){

		// 増減可能判定
		if (bou_pupbutton.k_bou_upp<=0) {
			k_boud_ok = false;
		} else {
			k_boud_ok = true;
		}
		
		if (k_boud_ok == false) {
			this.gameObject.SetActive (false);
		}
	}
	
	// マイナスＮＧボタン呼び出し
	public void MbouNGbuttonyobu(){
		if (k_boud_ok == false) {
			this.gameObject.SetActive (true);
		}
	}
	
	// 残りポイント表示
	public void K_Bougyo_NokoriP(){
		k_bou_nokori_p.text = "残筋：" + Csute.hero_Kin + "残敏：" + Csute.hero_Bin + "残心："+ Csute.hero_Men +"\n残魔："+ Csute.hero_Mag +"残器："+ Csute.hero_Sei ;
	}
	
	// 成長ポイント再表示
	public void Y_Kari_bou_kin_u(){
		k_bou_downt_kin.text = "筋：" + Csute.hero_Bougyo_kin ;
	}
	public void Y_Kari_bou_mag_u(){
		k_bou_downt_mag.text = "魔：" + Csute.hero_Bougyo_mag ;
	}
	public void Y_Kari_bou_bin_u(){
		k_bou_downt_bin.text = "敏：" + Csute.hero_Bougyo_bin ;
	}
	public void Y_Kari_bou_men_u(){
		k_bou_downt_men.text = "心：" + Csute.hero_Bougyo_men ;
	}
	public void Y_Kari_bou_sei_u(){
		k_bou_downt_sei.text = "器：" + Csute.hero_Bougyo_sei ;
	}
	
	// プラスボタン用意
	public void PbouOKbuton(){
		this.gameObject.SetActive (true);
	}
	
	// プラスＮＧボタン消す
	public void PbouNPbuton(){
		this.gameObject.SetActive (false);
	}
}