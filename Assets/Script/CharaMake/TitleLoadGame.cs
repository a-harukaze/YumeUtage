using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TitleLoadGame : MonoBehaviour {
	public Text titleloadG;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Taitoruoff(){
		this.gameObject.SetActive(false);
	}

	public void IkuseiStart(){
		this.gameObject.SetActive(true);
	}

	public void ForTitleLoad(){
		
		//主人公
		Csute.hero_name = PlayerPrefs.GetString ("s_h_name","");
		Csute.hero_HP = PlayerPrefs.GetInt ("s_hero_HP", 0);
		Csute.hero_Kougeki = PlayerPrefs.GetInt ("s_hero_Kougeki", 0);
		Csute.hero_Bougyo = PlayerPrefs.GetInt ("s_hero_Bougyo", 0);
		Csute.hero_Hit = PlayerPrefs.GetInt ("s_hero_Hit", 0);
		Csute.hero_Kaihi = PlayerPrefs.GetInt ("s_hero_Kaihi", 0);
		Csute.hero_Crit = PlayerPrefs.GetInt ("s_hero_Crit", 0);
		Csute.hero_Agi = PlayerPrefs.GetInt ("s_hero_Agi", 0);
		Csute.hero_Kin = PlayerPrefs.GetInt ("s_hero_Kin", 0);
		Csute.hero_Mag = PlayerPrefs.GetInt ("s_hero_Mag", 0);
		Csute.hero_Bin = PlayerPrefs.GetInt ("s_hero_Bin", 0);
		Csute.hero_Men = PlayerPrefs.GetInt ("s_hero_Men", 0);
		Csute.hero_Sei = PlayerPrefs.GetInt ("s_hero_Sei", 0);
		Csute.hero_Kin_U = PlayerPrefs.GetInt ("s_hero_Kin_U", 0);
		Csute.hero_Mag_U = PlayerPrefs.GetInt ("s_hero_Mag_U", 0);
		Csute.hero_Bin_U = PlayerPrefs.GetInt ("s_hero_Bin_U", 0);
		Csute.hero_Men_U = PlayerPrefs.GetInt ("s_hero_Men_U", 0);
		Csute.hero_Sei_U = PlayerPrefs.GetInt ("s_hero_Sei_U", 0);
		Csute.hero_UP_type = PlayerPrefs.GetString ("s_hero_UP_type","");
		Csute.n_teacher_ID = PlayerPrefs.GetInt ("s_n_teacher_ID", 0);
		Csute.hero_sentouP = PlayerPrefs.GetInt ("s_hero_sentouP", 0);
		Csute.hero_lank = PlayerPrefs.GetInt ("s_hero_lank", 0);

		// 師匠
		Csute.t_name  = PlayerPrefsX.GetStringArray ("s_t_name_full");
		Csute.t_Kin_U  = PlayerPrefsX.GetIntArray ("s_t_Kin_U ");
		Csute.t_Mag_U  = PlayerPrefsX.GetIntArray ("s_t_Mag_U ");
		Csute.t_Bin_U  = PlayerPrefsX.GetIntArray ("s_t_Bin_U ");
		Csute.t_Men_U  = PlayerPrefsX.GetIntArray ("s_t_Men_U ");
		Csute.t_Sei_U  = PlayerPrefsX.GetIntArray ("s_t_Sei_U ");
		
		Csute.t_kazu = PlayerPrefs.GetInt ("s_t_kazu", 0);
	}

	public void Loadgo_time(){
		//基本情報
		Csute.nen = PlayerPrefs.GetInt ("s_nen", 0);
		Csute.tuki = PlayerPrefs.GetInt ("s_tuki", 0);
		Csute.syu = PlayerPrefs.GetInt ("s_syu", 0);
		Csute.syukai = PlayerPrefs.GetInt ("s_syukai", 0);
		Csute.savekaisuu = PlayerPrefs.GetInt ("s_savekaisuu", 0);
		titleloadG.text= Csute.nen + "年目" + Csute.tuki + "月" + Csute.syu + "週";
	}
}
