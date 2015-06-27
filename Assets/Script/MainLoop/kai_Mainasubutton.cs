using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class kai_Mainasubutton : MonoBehaviour {
	
	public Text k_kai_nokori_p;
	
	public Text k_kai_downt_kin;
	public Text k_kai_downt_mag;
	public Text k_kai_downt_bin;
	public Text k_kai_downt_men;
	public Text k_kai_downt_sei;
	
	public Text k_kai_downt;
	static int k_kai_down_hojo;
	static bool k_kaid_ok;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// downdate is called once per frame
	void Update () {
		
	}
	
	// 仮入力ポイントを増やす 仮入力を表示 成長ポイント処理
	public void Kari_Kaihidown(){
		kai_pupbutton.k_kai_upp--;
		k_kai_downt.text = "" + kai_pupbutton.k_kai_upp;
		
		//　成長ポイント計算 １ポイント下がった状態で計算
		
		k_kai_down_hojo = Csute.hero_Kaihi - 1;
		Csute.hero_Kaihi_kin = k_kai_down_hojo/8+1;

		k_kai_down_hojo = Csute.hero_Kaihi - 1;
		Csute.hero_Kaihi_mag = k_kai_down_hojo/6+2;

		k_kai_down_hojo = Csute.hero_Kaihi - 1;
		Csute.hero_Kaihi_bin = k_kai_down_hojo/5+4;

		k_kai_down_hojo = Csute.hero_Kaihi - 1;
		Csute.hero_Kaihi_men = k_kai_down_hojo/6+2;

		k_kai_down_hojo = Csute.hero_Kaihi - 1;
		Csute.hero_Kaihi_sei = k_kai_down_hojo/6+3;

		Csute.hero_Kin += Csute.hero_Kaihi_kin;
		Csute.hero_Mag += Csute.hero_Kaihi_mag;
		Csute.hero_Bin += Csute.hero_Kaihi_bin;
		Csute.hero_Men += Csute.hero_Kaihi_men;
		Csute.hero_Sei += Csute.hero_Kaihi_sei;
	}
	
	// ＯＫボタン消去
	public void MkaiOKbuttonyobu(){

		// 増減可能判定
		if (kai_pupbutton.k_kai_upp<=0) {
			k_kaid_ok = false;
		} else {
			k_kaid_ok = true;
		}
		
		if (k_kaid_ok == false) {
			this.gameObject.SetActive (false);
		}
	}
	
	// マイナスＮＧボタン呼び出し
	public void MkaiNGbuttonyobu(){
		if (k_kaid_ok == false) {
			this.gameObject.SetActive (true);
		}
	}
	
	// 残りポイント表示
	public void K_Kaihi_NokoriP(){
		k_kai_nokori_p.text = "残筋：" + Csute.hero_Kin + "残敏：" + Csute.hero_Bin + "残心："+ Csute.hero_Men +"\n残魔："+ Csute.hero_Mag +"残器："+ Csute.hero_Sei ;
	}
	
	// 成長ポイント再表示
	public void Y_Kari_kai_kin_u(){
		k_kai_downt_kin.text = "筋：" + Csute.hero_Kaihi_kin ;
	}
	public void Y_Kari_kai_mag_u(){
		k_kai_downt_mag.text = "魔：" + Csute.hero_Kaihi_mag ;
	}
	public void Y_Kari_kai_bin_u(){
		k_kai_downt_bin.text = "敏：" + Csute.hero_Kaihi_bin ;
	}
	public void Y_Kari_kai_men_u(){
		k_kai_downt_men.text = "心：" + Csute.hero_Kaihi_men ;
	}
	public void Y_Kari_kai_sei_u(){
		k_kai_downt_sei.text = "器：" + Csute.hero_Kaihi_sei ;
	}
	
	// プラスボタン用意
	public void PkaiOKbuton(){
		this.gameObject.SetActive (true);
	}
	
	// プラスＮＧボタン消す
	public void PkaiNPbuton(){
		this.gameObject.SetActive (false);
	}
}