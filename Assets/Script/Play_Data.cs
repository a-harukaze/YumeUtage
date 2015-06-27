using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Play_Data : MonoBehaviour {
	public Text nowdata;
	public Text savedata;
	public Text timeloadgo;
	public Text loaddame;
	public static int s_savekaisuu;

	public static string s_h_name;
	public static int s_syukai;
	public static int s_nen;
	public static int s_tuki;
	public static int s_syu;
	public static int s_h_bp;
	public static string s_t_name;
	public static int s_tid;

	//主人公
	public static int s_hero_HP;
	public static int s_hero_Kougeki;
	public static int s_hero_Bougyo;
	public static int s_hero_Hit;
	public static int s_hero_Kaihi;
	public static int s_hero_Crit;
	public static int s_hero_Agi;
	public static int s_hero_Kin;
	public static int s_hero_Mag;
	public static int s_hero_Bin;
	public static int s_hero_Men;
	public static int s_hero_Sei;
	public static int s_hero_Kin_U;
	public static int s_hero_Mag_U;
	public static int s_hero_Bin_U;
	public static int s_hero_Men_U;
	public static int s_hero_Sei_U;
	public static string s_hero_UP_type;
	public static int s_n_teacher_ID;
	public static int s_hero_sentouP;
	public static int s_hero_lank;
	
	//師匠
	public static string[] s_t_name_full = new string[17];
	public static int[] s_t_Kin_U = new int[17];
	public static int[] s_t_Mag_U = new int[17];
	public static int[] s_t_Bin_U = new int[17];
	public static int[] s_t_Men_U = new int[17];
	public static int[] s_t_Sei_U = new int[17];
	public static int s_t_kazu;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Nowdata(){
		nowdata.text = "今の能力\n" +
			Csute.hero_name + "\n" + Csute.syukai + "週目" + Csute.nen + "年目" + Csute.tuki + "月" + Csute.syu + "週" + "\n"+
			"戦闘力：" + Csute.hero_sentouP + "\n" +
				"師匠：" + Csute.t_name [Csute.n_teacher_ID] + "\nセーブ回数：" + Csute.savekaisuu;

	}

	public void SaveDataKaku(){

		if (s_syukai != 0 ) {

			savedata.text = "セーブ時の\n" +
				s_h_name + "\n" + s_syukai + "週目" + s_nen + "年目" + s_tuki + "月" + s_syu + "週\n" +
				"戦闘力：" + s_h_bp + "\n" +
				"師匠：" + s_t_name;
		} else {
			savedata.text = "まだセーブされていません。";
		}
	}

	public void save(){

		Csute.savekaisuu++;
		s_savekaisuu = Csute.savekaisuu;

		// 主人公
		s_h_name = Csute.hero_name;
		PlayerPrefs.SetString ("s_h_name",s_h_name);
		s_hero_HP = Csute.hero_HP;
		PlayerPrefs.SetInt ("s_hero_HP",s_hero_HP);
		s_hero_Kougeki = Csute.hero_Kougeki;
		PlayerPrefs.SetInt ("s_hero_Kougeki",s_hero_Kougeki);
		s_hero_Bougyo = Csute.hero_Bougyo;
		PlayerPrefs.SetInt ("s_hero_Bougyo",s_hero_Bougyo);
		s_hero_Hit = Csute.hero_Hit;
		PlayerPrefs.SetInt ("s_hero_Hit",s_hero_Hit);
		s_hero_Kaihi = Csute.hero_Kaihi;
		PlayerPrefs.SetInt ("s_hero_Kaihi",s_hero_Kaihi);
		s_hero_Crit = Csute.hero_Crit;
		PlayerPrefs.SetInt ("s_hero_Crit",s_hero_Crit);
		s_hero_Agi = Csute.hero_Agi;
		PlayerPrefs.SetInt ("s_hero_Agi",s_hero_Agi);
		s_hero_Kin = Csute.hero_Kin;
		PlayerPrefs.SetInt ("s_hero_Kin",s_hero_Kin);
		s_hero_Mag = Csute.hero_Mag;
		PlayerPrefs.SetInt ("s_hero_Mag",s_hero_Mag);
		s_hero_Bin = Csute.hero_Bin;
		PlayerPrefs.SetInt ("s_hero_Bin",s_hero_Bin);
		s_hero_Men = Csute.hero_Men;
		PlayerPrefs.SetInt ("s_hero_Men",s_hero_Men);
		s_hero_Sei = Csute.hero_Sei;
		PlayerPrefs.SetInt ("s_hero_Sei",s_hero_Sei);
		s_hero_Kin_U = Csute.hero_Kin_U;
		PlayerPrefs.SetInt ("s_hero_Kin_U",s_hero_Kin_U);
		s_hero_Mag_U = Csute.hero_Mag_U;
		PlayerPrefs.SetInt ("s_hero_Mag_U",s_hero_Mag_U);
		s_hero_Bin_U = Csute.hero_Bin_U;
		PlayerPrefs.SetInt ("s_hero_Bin_U",s_hero_Bin_U);
		s_hero_Men_U = Csute.hero_Men_U;
		PlayerPrefs.SetInt ("s_hero_Men_U",s_hero_Men_U);
		s_hero_Sei_U = Csute.hero_Sei_U;
		PlayerPrefs.SetInt ("s_hero_Sei_U",s_hero_Sei_U);
		s_hero_UP_type = Csute.hero_UP_type;
		PlayerPrefs.SetString ("s_hero_UP_type",s_hero_UP_type);
		s_n_teacher_ID = Csute.n_teacher_ID;
		PlayerPrefs.SetInt ("s_n_teacher_ID",s_n_teacher_ID);
		s_hero_sentouP = Csute.hero_sentouP;
		PlayerPrefs.SetInt ("s_hero_sentouP",s_hero_sentouP);
		
		//基本情報
		s_nen = Csute.nen;
		PlayerPrefs.SetInt ("s_nen",s_nen);
		s_tuki = Csute.tuki;
		PlayerPrefs.SetInt ("s_tuki",s_tuki);
		s_syu = Csute.syu;
		PlayerPrefs.SetInt ("s_syu",s_syu);
		s_syukai = Csute.syukai;
		PlayerPrefs.SetInt ("s_syukai",s_syukai);
		s_savekaisuu = Csute.savekaisuu;
		PlayerPrefs.SetInt ("s_savekaisuu",s_savekaisuu);

		//師匠
		for (int idid = 0 ; idid <= 16; idid++){
			s_t_name_full[idid] = Csute.t_name[idid];
			PlayerPrefs.SetString("s_t_name_full[idid]", s_t_name_full[idid]);
			s_t_Kin_U[idid] = Csute.t_Kin_U[idid];
			PlayerPrefs.SetInt ("s_t_Kin_U[idid]", s_t_Kin_U[idid]);
			s_t_Mag_U[idid] = Csute.t_Mag_U[idid];
			PlayerPrefs.SetInt ("s_t_Mag_U[idid]", s_t_Mag_U[idid]);
			s_t_Bin_U[idid] = Csute.t_Bin_U[idid];
			PlayerPrefs.SetInt ("s_t_Bin_U[idid]", s_t_Bin_U[idid]);
			s_t_Men_U[idid] = Csute.t_Men_U[idid];
			PlayerPrefs.SetInt ("s_t_Men_U[idid]", s_t_Men_U[idid]);
			s_t_Sei_U[idid] = Csute.t_Sei_U[idid];
			PlayerPrefs.SetInt ("s_t_Sei_U[idid]", s_t_Sei_U[idid]);
		}
		s_t_kazu = Csute.t_kazu;
		PlayerPrefs.SetInt("s_t_kazu",s_t_kazu);

		PlayerPrefs.Save ();

	}

	public void Load(){
		if (Csute.savekaisuu != 0) {

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

			// 師匠
			for (int ttid =0; ttid <= 16; ttid ++) {
				Csute.t_name [ttid] = PlayerPrefs.GetString ("s_t_name_full [ttid]");
				Csute.t_Kin_U [ttid] = PlayerPrefs.GetInt ("s_t_Kin_U [ttid]", 0);
				Csute.t_Mag_U [ttid] = PlayerPrefs.GetInt ("s_t_Mag_U [ttid]", 0);
				Csute.t_Bin_U [ttid] = PlayerPrefs.GetInt ("s_t_Bin_U [ttid]", 0);
				Csute.t_Men_U [ttid] = PlayerPrefs.GetInt ("s_t_Men_U [ttid]", 0);
				Csute.t_Sei_U [ttid] = PlayerPrefs.GetInt ("s_t_Sei_U [ttid]", 0);
			}

			Csute.t_kazu = PlayerPrefs.GetInt ("s_t_kazu", 0);


		} else {
			loaddame.text = "セーブデータがありません。";
		}
	}

	public void Loadgo_time(){
		//基本情報
		Csute.nen = PlayerPrefs.GetInt ("s_nen", 0);
		Csute.tuki = PlayerPrefs.GetInt ("s_tuki", 0);
		Csute.syu = PlayerPrefs.GetInt ("s_syu", 0);
		Csute.syukai = PlayerPrefs.GetInt ("s_syukai", 0);
		Csute.savekaisuu = PlayerPrefs.GetInt ("s_savekaisuu", 0);
		timeloadgo.text= Csute.nen + "年目" + Csute.tuki + "月" + Csute.syu + "週";
	}

	public void GoTitle(){
		this.gameObject.SetActive (true);
	}

	public void ReturnIkusei(){
		this.gameObject.SetActive (false);
	}

	public void TitleOwari(){
		this.gameObject.SetActive (false);
	}

	public void IkuseiLoad(){
		this.gameObject.SetActive (true);
	}

	public void SystemObyobu(){
		this.gameObject.SetActive (true);
	}

	public void SaveGamenDel(){
		this.gameObject.SetActive (false);
	}

	public void LoadOKhan(){
		if(Csute.savekaisuu != 0){
			this.gameObject.SetActive (true);
		}
	}

	public void LoadNGhan(){
		if(Csute.savekaisuu == 0){
			this.gameObject.SetActive (true);
		}
	}

	public void Savenullbuttondel(){
		this.gameObject.SetActive (false);
	}

	public void GotitleLoadOK(){
		if (Csute.savekaisuu != 0) {
			gameObject.SetActive (true);
		}
	}
	
	public void GotitleLoadNG(){
		if (Csute.savekaisuu == 0) {
			gameObject.SetActive (true);
		}
	}
}
