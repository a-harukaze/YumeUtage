using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TButton3 : MonoBehaviour {
	public Text syokisute;
	private int aaa;
	private int bbb;
	public Text timehyouzi;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	// 師匠選択画面終了
	public void TSobEnd(){
		this.gameObject.SetActive (false);
	}
	
	// 能力決定表示
	public void SEntry(){
		this.gameObject.SetActive (true);
	}
	
	// 初期ステータス表示
	public void SsuteHyouzi(){
		Csute.n_teacher_ID = 2;
		Csute.hero_Kin_U = Csute.hero_Kin_U + Csute.t_Kin_U[2];
		Csute.hero_Mag_U = Csute.hero_Mag_U + Csute.t_Mag_U[2];
		Csute.hero_Bin_U = Csute.hero_Bin_U + Csute.t_Bin_U[2];
		Csute.hero_Men_U = Csute.hero_Men_U + Csute.t_Men_U[2];
		Csute.hero_Sei_U = Csute.hero_Sei_U + Csute.t_Sei_U[2];
		
		
		// 初期能力決定
		if (Csute.hero_UP_type == "平均型") {
			Csute.hero_HP = Random.Range (80, 120);
			Csute.hero_Kougeki = Random.Range (30, 60);
			Csute.hero_Bougyo = Random.Range (15, 30);
			Csute.hero_Hit = Random.Range (80, 120);
			Csute.hero_Kaihi = Random.Range (5, 15);
			Csute.hero_Crit = Random.Range (0, 4);
			Csute.hero_Agi = Random.Range (80, 120);
			
			Csute.hero_Kin = 0;
			Csute.hero_Mag = 0;
			Csute.hero_Bin = 0;
			Csute.hero_Men = 0;
			Csute.hero_Sei = 0;
		} else if (Csute.hero_UP_type == "パワー型") {
			Csute.hero_HP = Random.Range (100, 150);
			Csute.hero_Kougeki = Random.Range (40, 75);
			Csute.hero_Bougyo = Random.Range (22, 44);
			Csute.hero_Hit = Random.Range (70, 105);
			Csute.hero_Kaihi = Random.Range (0, 7);
			Csute.hero_Crit = Random.Range (0, 6);
			Csute.hero_Agi = Random.Range (70, 110);
			
			Csute.hero_Kin = 0;
			Csute.hero_Mag = 0;
			Csute.hero_Bin = 0;
			Csute.hero_Men = 0;
			Csute.hero_Sei = 0;
		} else if (Csute.hero_UP_type == "高速型") {
			Csute.hero_HP = Random.Range (70, 105);
			Csute.hero_Kougeki = Random.Range (20, 45);
			Csute.hero_Bougyo = Random.Range (10, 20);
			Csute.hero_Hit = Random.Range (100, 140);
			Csute.hero_Kaihi = Random.Range (10, 25);
			Csute.hero_Crit = Random.Range (0, 6);
			Csute.hero_Agi = Random.Range (100, 140);
			
			Csute.hero_Kin = 0;
			Csute.hero_Mag = 0;
			Csute.hero_Bin = 0;
			Csute.hero_Men = 0;
			Csute.hero_Sei = 0;
		}
		
		Csute.syukai += 1;
		Csute.nen = 1;
		Csute.tuki = 1;
		Csute.syu = 1;
		Csute.hero_lank =1;
		
		Csute.hero_sentouP = Csute.hero_HP;
		Csute.hero_sentouP += Csute.hero_Kougeki;
		Csute.hero_sentouP += Csute.hero_Bougyo;
		Csute.hero_sentouP += Csute.hero_Hit;
		Csute.hero_sentouP += Csute.hero_Kaihi;
		Csute.hero_sentouP += Csute.hero_Crit;
		Csute.hero_sentouP += Csute.hero_Agi;
		
		syokisute.text = "名前　：" + Csute.hero_name + "\n" +
			"ＨＰ　：" + Csute.hero_HP + "\n" +
				"攻撃力：" + Csute.hero_Kougeki + "\n" +
				"防御力：" + Csute.hero_Bougyo + "\n" +
				"命中力：" + Csute.hero_Hit + "\n" +
				"回避力：" + Csute.hero_Kaihi + "\n" +
				"会心力：" + Csute.hero_Crit + "\n" +
				"行動力：" + Csute.hero_Agi + "\n" +
				"戦闘力：" + Csute.hero_sentouP ;
	}
	
	public void Ftimehyouzi(){
		timehyouzi.text = Csute.nen + "年目" + Csute.tuki + "月" + Csute.syu + "週";
	}
}
