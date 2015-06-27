using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UP_yobidasi : MonoBehaviour {
	public static int pupkeisan;
	static bool hpu_ok;
	static bool kougekiu_ok;
	static bool bougyou_ok;
	static bool hitu_ok;
	static bool kaihiu_ok;
	static bool critu_ok;
	static bool agiu_ok;

	public Text nokori_p;

	public Text hp_kin_p;
	public Text hp_mag_p;
	public Text hp_bin_p;
	public Text hp_men_p;
	public Text hp_sei_p;

	public Text kou_kin_p;
	public Text kou_mag_p;
	public Text kou_bin_p;
	public Text kou_men_p;
	public Text kou_sei_p;

	public Text bou_kin_p;
	public Text bou_mag_p;
	public Text bou_bin_p;
	public Text bou_men_p;
	public Text bou_sei_p;

	public Text hit_kin_p;
	public Text hit_mag_p;
	public Text hit_bin_p;
	public Text hit_men_p;
	public Text hit_sei_p;

	public Text kai_kin_p;
	public Text kai_mag_p;
	public Text kai_bin_p;
	public Text kai_men_p;
	public Text kai_sei_p;

	public Text cri_kin_p;
	public Text cri_mag_p;
	public Text cri_bin_p;
	public Text cri_men_p;
	public Text cri_sei_p;

	public Text agi_kin_p;
	public Text agi_mag_p;
	public Text agi_bin_p;
	public Text agi_men_p;
	public Text agi_sei_p;

	public Text pup_n_hp;
	public Text pup_n_kou;
	public Text pup_n_bou;
	public Text pup_n_hit;
	public Text pup_n_kai;
	public Text pup_n_cri;
	public Text pup_n_agi;

	public Text kari_hp_f;
	public Text kari_kou_f;
	public Text kari_bou_f;
	public Text kari_hit_f;
	public Text kari_kai_f;
	public Text kari_cri_f;
	public Text kari_agi_f;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// 残り成長ポイント表示
	public void Nokori_p(){
		// 成長要求ポイント計算
		pupkeisan = Csute.hero_HP - 100;
		if (pupkeisan < 0) {
			Csute.hero_HP_kin = 3;
		}else{
			Csute.hero_HP_kin = pupkeisan/20+3;
		}
		pupkeisan = Csute.hero_HP - 100;
		if (pupkeisan < 0) {
			Csute.hero_HP_mag = 1;
		}else{
			Csute.hero_HP_mag = pupkeisan/30+1;
		}
		pupkeisan = Csute.hero_HP - 100;
		if (pupkeisan < 0) {
			Csute.hero_HP_bin = 1;
		}else{
			Csute.hero_HP_bin = pupkeisan/30+1;
		}
		pupkeisan = Csute.hero_HP - 100;
		if (pupkeisan < 0) {
			Csute.hero_HP_men = 1;
		}else{
			Csute.hero_HP_men = pupkeisan/30+1;
		}
		pupkeisan = Csute.hero_HP - 100;
		if (pupkeisan < 0) {
			Csute.hero_HP_sei = 1;
		}else{
			Csute.hero_HP_sei = pupkeisan/30+1;
		}
		
		pupkeisan = Csute.hero_Kougeki - 20;
		if (pupkeisan < 0) {
			Csute.hero_Kougeki_kin = 5;
		}else{
			Csute.hero_Kougeki_kin = pupkeisan/10+5;
		}
		pupkeisan = Csute.hero_Kougeki - 30;
		if (pupkeisan < 0) {
			Csute.hero_Kougeki_mag = 1;
		}else{
			Csute.hero_Kougeki_mag = pupkeisan/20+1;
		}
		pupkeisan = Csute.hero_Kougeki - 30;
		if (pupkeisan < 0) {
			Csute.hero_Kougeki_bin = 1;
		}else{
			Csute.hero_Kougeki_bin = pupkeisan/20+1;
		}
		pupkeisan = Csute.hero_Kougeki - 30;
		if (pupkeisan < 0) {
			Csute.hero_Kougeki_men = 1;
		}else{
			Csute.hero_Kougeki_men = pupkeisan/20+1;
		}
		pupkeisan = Csute.hero_Kougeki - 30;
		if (pupkeisan < 0) {
			Csute.hero_Kougeki_sei = 1;
		}else{
			Csute.hero_Kougeki_sei = pupkeisan/20+1;
		}
		
		pupkeisan = Csute.hero_Bougyo - 10;
		if (pupkeisan < 0) {
			Csute.hero_Bougyo_kin = 3;
		}else{
			Csute.hero_Bougyo_kin = pupkeisan/10+3;
		}
		pupkeisan = Csute.hero_Bougyo - 15;
		if (pupkeisan < 0) {
			Csute.hero_Bougyo_mag = 1;
		}else{
			Csute.hero_Bougyo_mag = pupkeisan/20+1;
		}
		pupkeisan = Csute.hero_Bougyo - 10;
		if (pupkeisan < 0) {
			Csute.hero_Bougyo_bin = 3;
		}else{
			Csute.hero_Bougyo_bin = pupkeisan/10+3;
		}
		pupkeisan = Csute.hero_Bougyo - 15;
		if (pupkeisan < 0) {
			Csute.hero_Bougyo_men = 1;
		}else{
			Csute.hero_Bougyo_men = pupkeisan/20+1;
		}
		pupkeisan = Csute.hero_Bougyo - 15;
		if (pupkeisan < 0) {
			Csute.hero_Bougyo_sei = 1;
		}else{
			Csute.hero_Bougyo_sei = pupkeisan/20+1;
		}
		
		pupkeisan = Csute.hero_Hit - 100;
		if (pupkeisan < 0) {
			Csute.hero_Hit_kin = 1;
		}else{
			Csute.hero_Hit_kin = pupkeisan/10+1;
		}
		pupkeisan = Csute.hero_Hit - 100;
		if (pupkeisan < 0) {
			Csute.hero_Hit_mag = 1;
		}else{
			Csute.hero_Hit_mag = pupkeisan/10+1;
		}
		pupkeisan = Csute.hero_Hit - 100;
		if (pupkeisan < 0) {
			Csute.hero_Hit_bin = 2;
		}else{
			Csute.hero_Hit_bin = pupkeisan/8+2;
		}
		pupkeisan = Csute.hero_Hit - 100;
		if (pupkeisan < 0) {
			Csute.hero_Hit_men = 2;
		}else{
			Csute.hero_Hit_men = pupkeisan/8+2;
		}
		pupkeisan = Csute.hero_Hit - 100;
		if (pupkeisan < 0) {
			Csute.hero_Hit_sei = 3;
		}else{
			Csute.hero_Hit_sei = pupkeisan/5+4;
		}
		
		pupkeisan = Csute.hero_Kaihi;
		Csute.hero_Kaihi_kin = pupkeisan/8+1;
		pupkeisan = Csute.hero_Kaihi;
		Csute.hero_Kaihi_mag = pupkeisan/6+2;
		pupkeisan = Csute.hero_Kaihi;
		Csute.hero_Kaihi_bin = pupkeisan/5+4;
		pupkeisan = Csute.hero_Kaihi;
		Csute.hero_Kaihi_men = pupkeisan/6+2;
		pupkeisan = Csute.hero_Kaihi;
		Csute.hero_Kaihi_sei = pupkeisan/6+3;
		
		pupkeisan = Csute.hero_Crit;
		Csute.hero_Crit_kin = pupkeisan/6+1;
		pupkeisan = Csute.hero_Crit;
		Csute.hero_Crit_mag = pupkeisan/5+2;
		pupkeisan = Csute.hero_Crit;
		Csute.hero_Crit_bin = pupkeisan/3+4;
		pupkeisan = Csute.hero_Crit;
		Csute.hero_Crit_men = pupkeisan/5+2;
		pupkeisan = Csute.hero_Crit;
		Csute.hero_Crit_sei = pupkeisan/3+4;
		
		pupkeisan = Csute.hero_Agi - 100;
		if (pupkeisan < 0) {
			Csute.hero_Agi_kin = 1;
		}else{
			Csute.hero_Agi_kin = pupkeisan/20+1;
		}
		pupkeisan = Csute.hero_Agi - 100;
		if (pupkeisan < 0) {
			Csute.hero_Agi_mag = 2;
		}else{
			Csute.hero_Agi_mag = pupkeisan/20+2;
		}
		pupkeisan = Csute.hero_Agi - 100;
		if (pupkeisan < 0) {
			Csute.hero_Agi_bin = 3;
		}else{
			Csute.hero_Agi_bin = pupkeisan/15+3;
		}
		pupkeisan = Csute.hero_Agi - 100;
		if (pupkeisan < 0) {
			Csute.hero_Agi_men = 2;
		}else{
			Csute.hero_Agi_men = pupkeisan/20+2;
		}
		pupkeisan = Csute.hero_Agi - 100;
		if (pupkeisan < 0) {
			Csute.hero_Agi_sei = 2;
		}else{
			Csute.hero_Agi_sei = pupkeisan/20+2;
		}

		// 増減可能判定
		if (Csute.hero_Kin >= Csute.hero_HP_kin && Csute.hero_Mag >= Csute.hero_HP_mag && Csute.hero_Bin >= Csute.hero_HP_bin && Csute.hero_Men >= Csute.hero_HP_men && Csute.hero_Sei >= Csute.hero_HP_sei) {
			hpu_ok = true;
		} else {
			hpu_ok = false;
		}
		
		if (Csute.hero_Kin >= Csute.hero_Kougeki_kin && Csute.hero_Mag >= Csute.hero_Kougeki_mag && Csute.hero_Bin >= Csute.hero_Kougeki_bin && Csute.hero_Men >= Csute.hero_Kougeki_men && Csute.hero_Sei >= Csute.hero_Kougeki_sei) {
			kougekiu_ok = true;
		} else {
			kougekiu_ok = false;
		}
		
		if (Csute.hero_Kin >= Csute.hero_Bougyo_kin && Csute.hero_Mag >= Csute.hero_Bougyo_mag && Csute.hero_Bin >= Csute.hero_Bougyo_bin && Csute.hero_Men >= Csute.hero_Bougyo_men && Csute.hero_Sei >= Csute.hero_Bougyo_sei) {
			bougyou_ok = true;
		} else {
			bougyou_ok = false;
		}
		
		if (Csute.hero_Kin >= Csute.hero_Hit_kin && Csute.hero_Mag >= Csute.hero_Hit_mag && Csute.hero_Bin >= Csute.hero_Hit_bin && Csute.hero_Men >= Csute.hero_Hit_men && Csute.hero_Sei >= Csute.hero_Hit_sei) {
			hitu_ok = true;
		} else {
			hitu_ok = false;
		}
		
		if (Csute.hero_Kin >= Csute.hero_Kaihi_kin && Csute.hero_Mag >= Csute.hero_Kaihi_mag && Csute.hero_Bin >= Csute.hero_Kaihi_bin && Csute.hero_Men >= Csute.hero_Kaihi_men && Csute.hero_Sei >= Csute.hero_Kaihi_sei) {
			kaihiu_ok = true;
		} else {
			kaihiu_ok = false;
		}
		
		if (Csute.hero_Kin >= Csute.hero_Crit_kin && Csute.hero_Mag >= Csute.hero_Crit_mag && Csute.hero_Bin >= Csute.hero_Crit_bin && Csute.hero_Men >= Csute.hero_Crit_men && Csute.hero_Sei >= Csute.hero_Crit_sei) {
			critu_ok = true;
		} else {
			critu_ok = false;
		}
		
		if (Csute.hero_Kin >= Csute.hero_Agi_kin && Csute.hero_Mag >= Csute.hero_Agi_mag && Csute.hero_Bin >= Csute.hero_Agi_bin && Csute.hero_Men >= Csute.hero_Agi_men && Csute.hero_Sei >= Csute.hero_Agi_sei) {
			agiu_ok = true;
		} else {
			agiu_ok = false;
		}
	}

	public void NokoriP_hyouzi(){
		nokori_p.text = "残筋：" + Csute.hero_Kin + "残敏：" + Csute.hero_Bin + "残心："+ Csute.hero_Men +"\n残魔："+ Csute.hero_Mag +"残器："+ Csute.hero_Sei ;
	}

	// 必要成長ポイント表示
	public void Y_hp_kin_u(){
		hp_kin_p.text = "筋：" + Csute.hero_HP_kin ;
	}
	public void Y_hp_mag_u(){
		hp_mag_p.text = "魔：" + Csute.hero_HP_mag ;
	}
	public void Y_hp_bin_u(){
		hp_bin_p.text = "敏：" + Csute.hero_HP_bin ;
	}
	public void Y_hp_men_u(){
		hp_men_p.text = "心：" + Csute.hero_HP_men ;
	}
	public void Y_hp_sei_u(){
		hp_sei_p.text = "器：" + Csute.hero_HP_sei ;
	}

	// 必要成長ポイント表示
	public void Y_kou_kin_u(){
		kou_kin_p.text = "筋：" + Csute.hero_Kougeki_kin ;
	}
	public void Y_kou_mag_u(){
		kou_mag_p.text = "魔：" + Csute.hero_Kougeki_mag ;
	}
	public void Y_kou_bin_u(){
		kou_bin_p.text = "敏：" + Csute.hero_Kougeki_bin ;
	}
	public void Y_kou_men_u(){
		kou_men_p.text = "心：" + Csute.hero_Kougeki_men ;
	}
	public void Y_kou_sei_u(){
		kou_sei_p.text = "器：" + Csute.hero_Kougeki_sei ;
	}

	// 必要成長ポイント表示
	public void Y_bou_kin_u(){
		bou_kin_p.text = "筋：" + Csute.hero_Bougyo_kin ;
	}
	public void Y_bou_mag_u(){
		bou_mag_p.text = "魔：" + Csute.hero_Bougyo_mag ;
	}
	public void Y_bou_bin_u(){
		bou_bin_p.text = "敏：" + Csute.hero_Bougyo_bin ;
	}
	public void Y_bou_men_u(){
		bou_men_p.text = "心：" + Csute.hero_Bougyo_men ;
	}
	public void Y_bou_sei_u(){
		bou_sei_p.text = "器：" + Csute.hero_Bougyo_sei ;
	}

	// 必要成長ポイント表示
	public void Y_hit_kin_u(){
		hit_kin_p.text = "筋：" + Csute.hero_Hit_kin ;
	}
	public void Y_hit_mag_u(){
		hit_mag_p.text = "魔：" + Csute.hero_Hit_mag ;
	}
	public void Y_hit_bin_u(){
		hit_bin_p.text = "敏：" + Csute.hero_Hit_bin ;
	}
	public void Y_hit_men_u(){
		hit_men_p.text = "心：" + Csute.hero_Hit_men ;
	}
	public void Y_hit_sei_u(){
		hit_sei_p.text = "器：" + Csute.hero_Hit_sei ;
	}

	// 必要成長ポイント表示
	public void Y_kai_kin_u(){
		kai_kin_p.text = "筋：" + Csute.hero_Kaihi_kin ;
	}
	public void Y_kai_mag_u(){
		kai_mag_p.text = "魔：" + Csute.hero_Kaihi_mag ;
	}
	public void Y_kai_bin_u(){
		kai_bin_p.text = "敏：" + Csute.hero_Kaihi_bin ;
	}
	public void Y_kai_men_u(){
		kai_men_p.text = "心：" + Csute.hero_Kaihi_men ;
	}
	public void Y_kai_sei_u(){
		kai_sei_p.text = "器：" + Csute.hero_Kaihi_sei ;
	}

	// 必要成長ポイント表示
	public void Y_cri_kin_u(){
		cri_kin_p.text = "筋：" + Csute.hero_Crit_kin ;
	}
	public void Y_cri_mag_u(){
		cri_mag_p.text = "魔：" + Csute.hero_Crit_mag ;
	}
	public void Y_cri_bin_u(){
		cri_bin_p.text = "敏：" + Csute.hero_Crit_bin ;
	}
	public void Y_cri_men_u(){
		cri_men_p.text = "心：" + Csute.hero_Crit_men ;
	}
	public void Y_cri_sei_u(){
		cri_sei_p.text = "器：" + Csute.hero_Crit_sei ;
	}

	// 必要成長ポイント表示
	public void Y_agi_kin_u(){
		agi_kin_p.text = "筋：" + Csute.hero_Agi_kin ;
	}
	public void Y_agi_mag_u(){
		agi_mag_p.text = "魔：" + Csute.hero_Agi_mag ;
	}
	public void Y_agi_bin_u(){
		agi_bin_p.text = "敏：" + Csute.hero_Agi_bin ;
	}
	public void Y_agi_men_u(){
		agi_men_p.text = "心：" + Csute.hero_Agi_men ;
	}
	public void Y_agi_sei_u(){
		agi_sei_p.text = "器：" + Csute.hero_Agi_sei ;
	}


	// パワーアップ画面呼び出し
	public void PUPyobu(){
		this.gameObject.SetActive (true);
	}

	// プラスＯＫボタン呼び出し
	public void PhpOKbuttonyobu(){
		if (hpu_ok == true) {
			this.gameObject.SetActive (true);
		} else {
			this.gameObject.SetActive (false);
		}
	}

	public void PkouOKbuttonyobu(){
		if (kougekiu_ok == true) {
			this.gameObject.SetActive (true);
		}else {
			this.gameObject.SetActive (false);
		}
	}

	public void PbouOKbuttonyobu(){
		if (bougyou_ok == true) {
			this.gameObject.SetActive (true);
		}else {
			this.gameObject.SetActive (false);
		}
	}

	public void PhitOKbuttonyobu(){
		if (hitu_ok == true) {
			this.gameObject.SetActive (true);
		}else {
			this.gameObject.SetActive (false);
		}
	}

	public void PkaiOKbuttonyobu(){
		if (kaihiu_ok == true) {
			this.gameObject.SetActive (true);
		}else {
			this.gameObject.SetActive (false);
		}
	}

	public void PcriOKbuttonyobu(){
		if (critu_ok == true) {
			this.gameObject.SetActive (true);
		}else {
			this.gameObject.SetActive (false);
		}
	}

	public void PagiOKbuttonyobu(){
		if (agiu_ok == true) {
			this.gameObject.SetActive (true);
		}else {
			this.gameObject.SetActive (false);
		}
	}

	// プラスＮＧボタン呼び出し
	public void PhpNGbuttonyobu(){
		if (hpu_ok == false) {
			this.gameObject.SetActive (true);
		}else {
			this.gameObject.SetActive (false);
		}
	}
	
	public void PkouNGbuttonyobu(){
		if (kougekiu_ok == false) {
			this.gameObject.SetActive (true);
		}else {
			this.gameObject.SetActive (false);
		}
	}
	
	public void PbouNGbuttonyobu(){
		if (bougyou_ok == false) {
			this.gameObject.SetActive (true);
		}else {
			this.gameObject.SetActive (false);
		}
	}
	
	public void PhitNGbuttonyobu(){
		if (hitu_ok == false) {
			this.gameObject.SetActive (true);
		}else {
			this.gameObject.SetActive (false);
		}
	}
	
	public void PkaiNGbuttonyobu(){
		if (kaihiu_ok == false) {
			this.gameObject.SetActive (true);
		}else {
			this.gameObject.SetActive (false);
		}
	}
	
	public void PcriNGbuttonyobu(){
		if (critu_ok == false) {
			this.gameObject.SetActive (true);
		}else {
			this.gameObject.SetActive (false);
		}
	}
	
	public void PagiNGbuttonyobu(){
		if (agiu_ok == false) {
			this.gameObject.SetActive (true);
		}else {
			this.gameObject.SetActive (false);
		}
	}

	// 育成メインオフ
	public void IMoff_PUP(){
		this.gameObject.SetActive (false);
	}

	// 現在値を表示
	public void Pup_n_hp(){
		pup_n_hp.text = "" + Csute.hero_HP;
	}
	public void Pup_n_kou(){
		pup_n_kou.text = "" + Csute.hero_Kougeki;
	}
	public void Pup_n_bou(){
		pup_n_bou.text = "" + Csute.hero_Bougyo;
	}
	public void Pup_n_hit(){
		pup_n_hit.text = "" + Csute.hero_Hit;
	}
	public void Pup_n_kai(){
		pup_n_kai.text = "" + Csute.hero_Kaihi;
	}
	public void Pup_n_cri(){
		pup_n_cri.text = "" + Csute.hero_Crit;
	}
	public void Pup_n_agi(){
		pup_n_agi.text = "" + Csute.hero_Agi;
	}

	// 上昇値初期化→入力
	public void Kari_hp_F(){
		hp_pupbutton.k_hp_upp = 0;
		kari_hp_f.text = "" + hp_pupbutton.k_hp_upp;
	}
	public void Kari_kou_F(){
		kou_pupbutton.k_kou_upp = 0;
		kari_kou_f.text = "" + kou_pupbutton.k_kou_upp;
	}
	public void Kari_bou_F(){
		bou_pupbutton.k_bou_upp = 0;
		kari_bou_f.text = "" + bou_pupbutton.k_bou_upp;
	}
	public void Kari_hit_F(){
		hit_pupbutton.k_hit_upp = 0;
		kari_hit_f.text = "" + hit_pupbutton.k_hit_upp;
	}
	public void Kari_kai_F(){
		kai_pupbutton.k_kai_upp = 0;
		kari_kai_f.text = "" + kai_pupbutton.k_kai_upp;
	}
	public void Kari_cri_F(){
		cri_pupbutton.k_cri_upp = 0;
		kari_cri_f.text = "" + cri_pupbutton.k_cri_upp;
	}
	public void Kari_agi_F(){
		agi_pupbutton.k_agi_upp = 0;
		kari_agi_f.text = "" + agi_pupbutton.k_agi_upp;
	}

	public void MOK_hp(){
		this.gameObject.SetActive(false);
	}
	public void MOK_kou(){
		this.gameObject.SetActive(false);
	}
	public void MOK_Bou(){
		this.gameObject.SetActive(false);
	}
	public void MOK_hit(){
		this.gameObject.SetActive(false);
	}
	public void MOK_kai(){
		this.gameObject.SetActive(false);
	}
	public void MOK_cri(){
		this.gameObject.SetActive(false);
	}
	public void MOK_agi(){
		this.gameObject.SetActive(false);
	}

	public void MNK_hp(){
		this.gameObject.SetActive(true);
	}
	public void MNK_kou(){
		this.gameObject.SetActive(true);
	}
	public void MNK_Bou(){
		this.gameObject.SetActive(true);
	}
	public void MNK_hit(){
		this.gameObject.SetActive(true);
	}
	public void MNK_kai(){
		this.gameObject.SetActive(true);
	}
	public void MNK_cri(){
		this.gameObject.SetActive(true);
	}
	public void MNK_agi(){
		this.gameObject.SetActive(true);
	}
}
