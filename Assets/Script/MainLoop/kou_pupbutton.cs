using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class kou_pupbutton : MonoBehaviour {
	public static int k_kou_upp;
	public Text k_kou_nokori_p;
	
	public Text k_kou_upt_kin;
	public Text k_kou_upt_mag;
	public Text k_kou_upt_bin;
	public Text k_kou_upt_men;
	public Text k_kou_upt_sei;
	
	public Text k_kou_upt;
	static int k_kou_up_hojo;
	static bool k_kouu_ok;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	// 仮入力ポイントを増やす 仮入力を表示 成長ポイント処理
	public void Kari_KougekiUP(){
		k_kou_upp++;
		k_kou_upt.text = "" + k_kou_upp;
		
		Csute.hero_Kin -= Csute.hero_Kougeki_kin;
		Csute.hero_Mag -= Csute.hero_Kougeki_mag;
		Csute.hero_Bin -= Csute.hero_Kougeki_bin;
		Csute.hero_Men -= Csute.hero_Kougeki_men;
		Csute.hero_Sei -= Csute.hero_Kougeki_sei;
	}
	
	// プラスＯＫボタン消去
	public void PKkouOKbuttonyobu(){
		// 増減可能判定
		if (Csute.hero_Kin >= Csute.hero_Kougeki_kin && Csute.hero_Mag >= Csute.hero_Kougeki_mag && Csute.hero_Bin >= Csute.hero_Kougeki_bin && Csute.hero_Men >= Csute.hero_Kougeki_men && Csute.hero_Sei >= Csute.hero_Kougeki_sei) {
			k_kouu_ok = true;
		} else {
			k_kouu_ok = false;
		}
		
		if (k_kouu_ok == false) {
			this.gameObject.SetActive (false);
		}else if(k_kouu_ok == true){
			this.gameObject.SetActive (true);
		}
	}
	
	// プラスＮＧボタン呼び出し
	public void PKkouNGbuttonyobu(){
		if (k_kouu_ok == false) {
			this.gameObject.SetActive (true);
		}else if(k_kouu_ok == true){
			this.gameObject.SetActive (false);
		}
	}
	
	// 残りポイント表示
	public void K_Kougeki_NokoriP(){
		k_kou_nokori_p.text = "残筋：" + Csute.hero_Kin + "残敏：" + Csute.hero_Bin + "残心："+ Csute.hero_Men +"\n残魔："+ Csute.hero_Mag +"残器："+ Csute.hero_Sei ;
	}
	
	// 成長ポイント再表示
	public void Y_Kari_kou_kin_u(){
		k_kou_upt_kin.text = "筋：" + Csute.hero_Kougeki_kin ;
	}
	public void Y_Kari_kou_mag_u(){
		k_kou_upt_mag.text = "魔：" + Csute.hero_Kougeki_mag ;
	}
	public void Y_Kari_kou_bin_u(){
		k_kou_upt_bin.text = "敏：" + Csute.hero_Kougeki_bin ;
	}
	public void Y_Kari_kou_men_u(){
		k_kou_upt_men.text = "心：" + Csute.hero_Kougeki_men ;
	}
	public void Y_Kari_kou_sei_u(){
		k_kou_upt_sei.text = "器：" + Csute.hero_Kougeki_sei ;
	}
	
	// マイナスボタン用意
	public void PMKkouOKbuton(){
		this.gameObject.SetActive (true);
	}
	
	// マイナスＮＧボタン消す
	public void PMKkouNPbuton(){
		this.gameObject.SetActive (false);
	}
}
