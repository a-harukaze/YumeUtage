using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class kou_Mainasubutton : MonoBehaviour {
	
	public Text k_kou_nokori_p;
	
	public Text k_kou_downt_kin;
	public Text k_kou_downt_mag;
	public Text k_kou_downt_bin;
	public Text k_kou_downt_men;
	public Text k_kou_downt_sei;
	
	public Text k_kou_downt;
	static int k_kou_down_hojo;
	static bool k_koud_ok;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// downdate is called once per frame
	void Update () {
		
	}
	
	// 仮入力ポイントを増やす 仮入力を表示 成長ポイント処理
	public void Kari_Kougekidown(){
		kou_pupbutton.k_kou_upp--;
		k_kou_downt.text = "" + kou_pupbutton.k_kou_upp;
		
		//　成長ポイント計算 １ポイント下がった状態で計算
		
		k_kou_down_hojo = Csute.hero_Kougeki - 21;
		if (k_kou_down_hojo < 0) {
			Csute.hero_Kougeki_kin = 5;
		}else{
			Csute.hero_Kougeki_kin = k_kou_down_hojo/10+5;
		}
		k_kou_down_hojo = Csute.hero_Kougeki - 31;
		if (k_kou_down_hojo < 0) {
			Csute.hero_Kougeki_mag = 1;
		}else{
			Csute.hero_Kougeki_mag = k_kou_down_hojo/20+1;
		}
		k_kou_down_hojo = Csute.hero_Kougeki - 31;
		if (k_kou_down_hojo < 0) {
			Csute.hero_Kougeki_bin = 1;
		}else{
			Csute.hero_Kougeki_bin = k_kou_down_hojo/20+1;
		}
		k_kou_down_hojo = Csute.hero_Kougeki - 31;
		if (k_kou_down_hojo < 0) {
			Csute.hero_Kougeki_men = 1;
		}else{
			Csute.hero_Kougeki_men = k_kou_down_hojo/20+1;
		}
		k_kou_down_hojo = Csute.hero_Kougeki - 31;
		if (k_kou_down_hojo < 0) {
			Csute.hero_Kougeki_sei = 1;
		}else{
			Csute.hero_Kougeki_sei = k_kou_down_hojo/20+1;
		}
		
		Csute.hero_Kin += Csute.hero_Kougeki_kin;
		Csute.hero_Mag += Csute.hero_Kougeki_mag;
		Csute.hero_Bin += Csute.hero_Kougeki_bin;
		Csute.hero_Men += Csute.hero_Kougeki_men;
		Csute.hero_Sei += Csute.hero_Kougeki_sei;

		if (Csute.hero_Kin >= Csute.hero_Kougeki_kin && Csute.hero_Mag >= Csute.hero_Kougeki_mag && Csute.hero_Bin >= Csute.hero_Kougeki_bin && Csute.hero_Men >= Csute.hero_Kougeki_men && Csute.hero_Sei >= Csute.hero_Kougeki_sei) {
			if(kou_pupbutton.k_kou_upp<=0){
				kou_pupbutton.k_kou_upp = 1;
			}
		}
	}
	
	// ＯＫボタン消去
	public void MkouOKbuttonyobu(){

		// 増減可能判定
		if (kou_pupbutton.k_kou_upp<=0) {
			k_koud_ok = false;
		} else {
			k_koud_ok = true;
		}
		
		if (k_koud_ok == false) {
			this.gameObject.SetActive (false);
		}
	}
	
	// マイナスＮＧボタン呼び出し
	public void MkouNGbuttonyobu(){
		if (k_koud_ok == false) {
			this.gameObject.SetActive (true);
		}
	}
	
	// 残りポイント表示
	public void K_Kougeki_NokoriP(){
		k_kou_nokori_p.text = "残筋：" + Csute.hero_Kin + "残敏：" + Csute.hero_Bin + "残心："+ Csute.hero_Men +"\n残魔："+ Csute.hero_Mag +"残器："+ Csute.hero_Sei ;
	}
	
	// 成長ポイント再表示
	public void Y_Kari_kou_kin_u(){
		k_kou_downt_kin.text = "筋：" + Csute.hero_Kougeki_kin ;
	}
	public void Y_Kari_kou_mag_u(){
		k_kou_downt_mag.text = "魔：" + Csute.hero_Kougeki_mag ;
	}
	public void Y_Kari_kou_bin_u(){
		k_kou_downt_bin.text = "敏：" + Csute.hero_Kougeki_bin ;
	}
	public void Y_Kari_kou_men_u(){
		k_kou_downt_men.text = "心：" + Csute.hero_Kougeki_men ;
	}
	public void Y_Kari_kou_sei_u(){
		k_kou_downt_sei.text = "器：" + Csute.hero_Kougeki_sei ;
	}
	
	// プラスボタン用意
	public void PkouOKbuton(){
		this.gameObject.SetActive (true);
	}
	
	// プラスＮＧボタン消す
	public void PkouNPbuton(){
		this.gameObject.SetActive (false);
	}
}