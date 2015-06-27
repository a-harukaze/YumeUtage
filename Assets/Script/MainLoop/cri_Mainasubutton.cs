using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cri_Mainasubutton : MonoBehaviour {
	
	public Text k_cri_nokori_p;
	
	public Text k_cri_downt_kin;
	public Text k_cri_downt_mag;
	public Text k_cri_downt_bin;
	public Text k_cri_downt_men;
	public Text k_cri_downt_sei;
	
	public Text k_cri_downt;
	static int k_cri_down_hojo;
	static bool k_crid_ok;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// downdate is called once per frame
	void Update () {
		
	}
	
	// 仮入力ポイントを増やす 仮入力を表示 成長ポイント処理
	public void Kari_Critdown(){
		cri_pupbutton.k_cri_upp--;
		k_cri_downt.text = "" + cri_pupbutton.k_cri_upp;
		
		//　成長ポイント計算 １ポイント下がった状態で計算
		
		k_cri_down_hojo = Csute.hero_Crit - 1;
		Csute.hero_Crit_kin = k_cri_down_hojo/6+3;

		k_cri_down_hojo = Csute.hero_Crit - 1;
		Csute.hero_Crit_mag = k_cri_down_hojo/5+2;

		k_cri_down_hojo = Csute.hero_Crit - 1;
		Csute.hero_Crit_bin = k_cri_down_hojo/3+4;

		k_cri_down_hojo = Csute.hero_Crit - 1;
		Csute.hero_Crit_men = k_cri_down_hojo/5+2;

		k_cri_down_hojo = Csute.hero_Crit - 1;
		Csute.hero_Crit_sei = k_cri_down_hojo/3+4;

		Csute.hero_Kin += Csute.hero_Crit_kin;
		Csute.hero_Mag += Csute.hero_Crit_mag;
		Csute.hero_Bin += Csute.hero_Crit_bin;
		Csute.hero_Men += Csute.hero_Crit_men;
		Csute.hero_Sei += Csute.hero_Crit_sei;
	}
	
	// ＯＫボタン消去
	public void McriOKbuttonyobu(){

		// 増減可能判定
		if (cri_pupbutton.k_cri_upp<=0) {
			k_crid_ok = false;
		} else {
			k_crid_ok = true;
		}
		
		if (k_crid_ok == false) {
			this.gameObject.SetActive (false);
		}
	}
	
	// マイナスＮＧボタン呼び出し
	public void McriNGbuttonyobu(){
		if (k_crid_ok == false) {
			this.gameObject.SetActive (true);
		}
	}
	
	// 残りポイント表示
	public void K_Crit_NokoriP(){
		k_cri_nokori_p.text = "残筋：" + Csute.hero_Kin + "残敏：" + Csute.hero_Bin + "残心："+ Csute.hero_Men +"\n残魔："+ Csute.hero_Mag +"残器："+ Csute.hero_Sei ;
	}
	
	// 成長ポイント再表示
	public void Y_Kari_cri_kin_u(){
		k_cri_downt_kin.text = "筋：" + Csute.hero_Crit_kin ;
	}
	public void Y_Kari_cri_mag_u(){
		k_cri_downt_mag.text = "魔：" + Csute.hero_Crit_mag ;
	}
	public void Y_Kari_cri_bin_u(){
		k_cri_downt_bin.text = "敏：" + Csute.hero_Crit_bin ;
	}
	public void Y_Kari_cri_men_u(){
		k_cri_downt_men.text = "心：" + Csute.hero_Crit_men ;
	}
	public void Y_Kari_cri_sei_u(){
		k_cri_downt_sei.text = "器：" + Csute.hero_Crit_sei ;
	}
	
	// プラスボタン用意
	public void PcriOKbuton(){
		this.gameObject.SetActive (true);
	}
	
	// プラスＮＧボタン消す
	public void PcriNPbuton(){
		this.gameObject.SetActive (false);
	}
}