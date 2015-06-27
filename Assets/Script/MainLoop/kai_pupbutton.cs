using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class kai_pupbutton : MonoBehaviour {
	public static int k_kai_upp;
	public Text k_kai_nokori_p;
	
	public Text k_kai_upt_kin;
	public Text k_kai_upt_mag;
	public Text k_kai_upt_bin;
	public Text k_kai_upt_men;
	public Text k_kai_upt_sei;
	
	public Text k_kai_upt;
	static int k_kai_up_hojo;
	static bool k_kaiu_ok;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	// 仮入力ポイントを増やす 仮入力を表示 成長ポイント処理
	public void Kari_KaihiUP(){
		k_kai_upp++;
		k_kai_upt.text = "" + k_kai_upp;
		
		Csute.hero_Kin -= Csute.hero_Kaihi_kin;
		Csute.hero_Mag -= Csute.hero_Kaihi_mag;
		Csute.hero_Bin -= Csute.hero_Kaihi_bin;
		Csute.hero_Men -= Csute.hero_Kaihi_men;
		Csute.hero_Sei -= Csute.hero_Kaihi_sei;
	}
	
	// プラスＯＫボタン消去
	public void PKkaiOKbuttonyobu(){
		// 増減可能判定
		if (Csute.hero_Kin >= Csute.hero_Kaihi_kin && Csute.hero_Mag >= Csute.hero_Kaihi_mag && Csute.hero_Bin >= Csute.hero_Kaihi_bin && Csute.hero_Men >= Csute.hero_Kaihi_men && Csute.hero_Sei >= Csute.hero_Kaihi_sei) {
			k_kaiu_ok = true;
		} else {
			k_kaiu_ok = false;
		}
		
		if (k_kaiu_ok == false) {
			this.gameObject.SetActive (false);
		}else if(k_kaiu_ok == true){
			this.gameObject.SetActive (true);
		}
	}
	
	// プラスＮＧボタン呼び出し
	public void PKkaiNGbuttonyobu(){
		if (k_kaiu_ok == false) {
			this.gameObject.SetActive (true);
		}else if(k_kaiu_ok == true){
			this.gameObject.SetActive (false);
		}
	}
	
	// 残りポイント表示
	public void K_Kaihi_NokoriP(){
		k_kai_nokori_p.text = "残筋：" + Csute.hero_Kin + "残敏：" + Csute.hero_Bin + "残心："+ Csute.hero_Men +"\n残魔："+ Csute.hero_Mag +"残器："+ Csute.hero_Sei ;
	}
	
	// 成長ポイント再表示
	public void Y_Kari_kai_kin_u(){
		k_kai_upt_kin.text = "筋：" + Csute.hero_Kaihi_kin ;
	}
	public void Y_Kari_kai_mag_u(){
		k_kai_upt_mag.text = "魔：" + Csute.hero_Kaihi_mag ;
	}
	public void Y_Kari_kai_bin_u(){
		k_kai_upt_bin.text = "敏：" + Csute.hero_Kaihi_bin ;
	}
	public void Y_Kari_kai_men_u(){
		k_kai_upt_men.text = "心：" + Csute.hero_Kaihi_men ;
	}
	public void Y_Kari_kai_sei_u(){
		k_kai_upt_sei.text = "器：" + Csute.hero_Kaihi_sei ;
	}
	
	// マイナスボタン用意
	public void PMKkaiOKbuton(){
		this.gameObject.SetActive (true);
	}
	
	// マイナスＮＧボタン消す
	public void PMKkaiNPbuton(){
		this.gameObject.SetActive (false);
	}
}
