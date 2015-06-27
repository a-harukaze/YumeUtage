using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hit_Mainasubutton : MonoBehaviour {
	
	public Text k_hit_nokori_p;
	
	public Text k_hit_downt_kin;
	public Text k_hit_downt_mag;
	public Text k_hit_downt_bin;
	public Text k_hit_downt_men;
	public Text k_hit_downt_sei;
	
	public Text k_hit_downt;
	static int k_hit_down_hojo;
	static bool k_hitd_ok;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// downdate is called once per frame
	void Update () {
		
	}
	
	// 仮入力ポイントを増やす 仮入力を表示 成長ポイント処理
	public void Kari_Hitdown(){
		hit_pupbutton.k_hit_upp--;
		k_hit_downt.text = "" + hit_pupbutton.k_hit_upp;
		
		//　成長ポイント計算 １ポイント下がった状態で計算
		
		k_hit_down_hojo = Csute.hero_Hit - 101;
		if (k_hit_down_hojo < 0) {
			Csute.hero_Hit_kin = 1;
		}else{
			Csute.hero_Hit_kin = k_hit_down_hojo/10+1;
		}
		k_hit_down_hojo = Csute.hero_Hit - 101;
		if (k_hit_down_hojo < 0) {
			Csute.hero_Hit_mag = 1;
		}else{
			Csute.hero_Hit_mag = k_hit_down_hojo/10+1;
		}
		k_hit_down_hojo = Csute.hero_Hit - 101;
		if (k_hit_down_hojo < 0) {
			Csute.hero_Hit_bin = 2;
		}else{
			Csute.hero_Hit_bin = k_hit_down_hojo/8+2;
		}
		k_hit_down_hojo = Csute.hero_Hit - 101;
		if (k_hit_down_hojo < 0) {
			Csute.hero_Hit_men = 2;
		}else{
			Csute.hero_Hit_men = k_hit_down_hojo/8+2;
		}
		k_hit_down_hojo = Csute.hero_Hit - 101;
		if (k_hit_down_hojo < 0) {
			Csute.hero_Hit_sei = 3;
		}else{
			Csute.hero_Hit_sei = k_hit_down_hojo/6+4;
		}
		
		Csute.hero_Kin += Csute.hero_Hit_kin;
		Csute.hero_Mag += Csute.hero_Hit_mag;
		Csute.hero_Bin += Csute.hero_Hit_bin;
		Csute.hero_Men += Csute.hero_Hit_men;
		Csute.hero_Sei += Csute.hero_Hit_sei;
	}
	
	// ＯＫボタン消去
	public void MhitOKbuttonyobu(){

		// 増減可能判定
		if(hit_pupbutton.k_hit_upp<=0){
			k_hitd_ok = false;
		} else {
			k_hitd_ok = true;
		}
		
		if (k_hitd_ok == false) {
			this.gameObject.SetActive (false);
		}
	}
	
	// マイナスＮＧボタン呼び出し
	public void MhitNGbuttonyobu(){
		if (k_hitd_ok == false) {
			this.gameObject.SetActive (true);
		}
	}
	
	// 残りポイント表示
	public void K_Hit_NokoriP(){
		k_hit_nokori_p.text = "残筋：" + Csute.hero_Kin + "残敏：" + Csute.hero_Bin + "残心："+ Csute.hero_Men +"\n残魔："+ Csute.hero_Mag +"残器："+ Csute.hero_Sei ;
	}
	
	// 成長ポイント再表示
	public void Y_Kari_hit_kin_u(){
		k_hit_downt_kin.text = "筋：" + Csute.hero_Hit_kin ;
	}
	public void Y_Kari_hit_mag_u(){
		k_hit_downt_mag.text = "魔：" + Csute.hero_Hit_mag ;
	}
	public void Y_Kari_hit_bin_u(){
		k_hit_downt_bin.text = "敏：" + Csute.hero_Hit_bin ;
	}
	public void Y_Kari_hit_men_u(){
		k_hit_downt_men.text = "心：" + Csute.hero_Hit_men ;
	}
	public void Y_Kari_hit_sei_u(){
		k_hit_downt_sei.text = "器：" + Csute.hero_Hit_sei ;
	}
	
	// プラスボタン用意
	public void PhitOKbuton(){
		this.gameObject.SetActive (true);
	}
	
	// プラスＮＧボタン消す
	public void PhitNPbuton(){
		this.gameObject.SetActive (false);
	}
}