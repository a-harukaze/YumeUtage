using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bou_pupbutton : MonoBehaviour {
	public static int k_bou_upp;
	public Text k_bou_nokori_p;
	
	public Text k_bou_upt_kin;
	public Text k_bou_upt_mag;
	public Text k_bou_upt_bin;
	public Text k_bou_upt_men;
	public Text k_bou_upt_sei;
	
	public Text k_bou_upt;
	static int k_bou_up_hojo;
	static bool k_bouu_ok;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	// 仮入力ポイントを増やす 仮入力を表示 成長ポイント処理
	public void Kari_BouUP(){
		k_bou_upp++;
		k_bou_upt.text = "" + k_bou_upp;
		
		Csute.hero_Kin -= Csute.hero_Bougyo_kin;
		Csute.hero_Mag -= Csute.hero_Bougyo_mag;
		Csute.hero_Bin -= Csute.hero_Bougyo_bin;
		Csute.hero_Men -= Csute.hero_Bougyo_men;
		Csute.hero_Sei -= Csute.hero_Bougyo_sei;
	}
	
	// プラスＯＫボタン消去
	public void PKbouOKbuttonyobu(){
		// 増減可能判定
		if (Csute.hero_Kin >= Csute.hero_Bougyo_kin && Csute.hero_Mag >= Csute.hero_Bougyo_mag && Csute.hero_Bin >= Csute.hero_Bougyo_bin && Csute.hero_Men >= Csute.hero_Bougyo_men && Csute.hero_Sei >= Csute.hero_Bougyo_sei) {
			k_bouu_ok = true;
		} else {
			k_bouu_ok = false;
		}
		
		if (k_bouu_ok == false) {
			this.gameObject.SetActive (false);
		}else if(k_bouu_ok == true){
			this.gameObject.SetActive (true);
		}
	}
	
	// プラスＮＧボタン呼び出し
	public void PKbouNGbuttonyobu(){
		if (k_bouu_ok == false) {
			this.gameObject.SetActive (true);
		}else if(k_bouu_ok == true){
			this.gameObject.SetActive (false);
		}
	}
	
	// 残りポイント表示
	public void K_Bou_NokoriP(){
		k_bou_nokori_p.text = "残筋：" + Csute.hero_Kin + "残敏：" + Csute.hero_Bin + "残心："+ Csute.hero_Men +"\n残魔："+ Csute.hero_Mag +"残器："+ Csute.hero_Sei ;
	}
	
	// 成長ポイント再表示
	public void Y_Kari_bou_kin_u(){
		k_bou_upt_kin.text = "筋：" + Csute.hero_Bougyo_kin ;
	}
	public void Y_Kari_bou_mag_u(){
		k_bou_upt_mag.text = "魔：" + Csute.hero_Bougyo_mag ;
	}
	public void Y_Kari_bou_bin_u(){
		k_bou_upt_bin.text = "敏：" + Csute.hero_Bougyo_bin ;
	}
	public void Y_Kari_bou_men_u(){
		k_bou_upt_men.text = "心：" + Csute.hero_Bougyo_men ;
	}
	public void Y_Kari_bou_sei_u(){
		k_bou_upt_sei.text = "器：" + Csute.hero_Bougyo_sei ;
	}
	
	// マイナスボタン用意
	public void PMKbouOKbuton(){
		this.gameObject.SetActive (true);
	}
	
	// マイナスＮＧボタン消す
	public void PMKbouNPbuton(){
		this.gameObject.SetActive (false);
	}
}
