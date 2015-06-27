using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class JuunanTaisou : MonoBehaviour {
	static int kin_u;
	static int mag_u;
	static int bin_u;
	static int men_u;
	static int sei_u;
	
	public Text kin_u_text;
	public Text mag_u_text;
	public Text bin_u_text;
	public Text men_u_text;
	public Text sei_u_text;
	
	static int kintore_u;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	// 結果表示
	public void Kin_U_P(){
		kin_u = Random.Range (3,7);
		kin_u *= Csute.hero_Kin_U;
		kin_u /= 100;
		Csute.hero_Kin += kin_u;
		if (kin_u == 0) {
			kin_u_text.text = "0";
		} else {
			kin_u_text.text = kin_u + "↑";
		}
	}
	
	public void Mag_U_P(){
		mag_u = Random.Range (3,7);
		mag_u *= Csute.hero_Mag_U;
		mag_u /= 100;
		Csute.hero_Mag += mag_u;
		if (mag_u == 0) {
			mag_u_text.text = "0";
		} else {
			mag_u_text.text = mag_u + "↑";
		}
	}
	
	public void Bin_U_P(){
		bin_u = Random.Range (3,7);
		bin_u *= Csute.hero_Bin_U;
		bin_u /= 100;
		Csute.hero_Bin += bin_u;
		if (bin_u == 0) {
			bin_u_text.text = "0";
		} else {
			bin_u_text.text = bin_u + "↑";
		}
	}
	
	public void Men_U_P(){
		men_u = Random.Range (6,14);
		men_u *= Csute.hero_Men_U;
		men_u /= 100;
		Csute.hero_Men += men_u;
		if (men_u == 0) {
			men_u_text.text = "0";
		} else {
			men_u_text.text = men_u + "↑";
		}
	}
	
	public void Sei_U_P(){
		sei_u = Random.Range (3,7);
		sei_u *= Csute.hero_Sei_U;
		sei_u /= 100;
		Csute.hero_Sei += sei_u;
		if (sei_u == 0) {
			sei_u_text.text = "0";
		} else {
			sei_u_text.text = sei_u + "↑";
		}
	}
	
	// 育成画面消す
	public void IMDel(){
		this.gameObject.SetActive (false);
	}
	
	// 育成リザルト画面出す
	public void IROpen(){
		this.gameObject.SetActive (true);
	}
	
	
}
