using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;

public class BattleMain : MonoBehaviour {
	public Text taikaibs;
	public Text th_name;
	public Text te_name;
	public TextAsset csv;
	public Text te_hp;
	public Text th_hp;
	public Slider h_hp_gage;
	public Slider e_hp_gage;
	static float h_gage_keisan;
	static float e_gage_keisan;
	public Text battle_text;
	public Text end_text;
	public Text timehyouzi;

	// 相手のステータス
	static int rand_ename;
	static string e_name;
	static int h_hp;
	static int e_hp;
	static int en_hp;
	static int e_kou;
	static int e_bou;
	static int e_hit;
	static int e_kai;
	static int e_cri;
	static int e_agi;

	// 戦闘処理
	static int koudou_hantei;
	static int h_dame;
	static int e_dame;
	static int h_koudou;
	static int e_koudou;
	static int turn;
	static int hit_or_miss;
	static bool battle_end;
	static int kaisin;
	static int kougekigawa;
	static int syourihantei;
	static bool h_miss;
	static bool e_miss;

	// 戦闘後
	public static bool go_next_battle;
	public static bool go_ikusei_main;
	public static bool yusyou;
	static int b_e_count;

	// 効果音
	public AudioClip hit;
	public AudioClip crit;
	public AudioClip syouri;
	public AudioClip kettei;
	public AudioSource se_b;

	// Use this for initialization
	void Start () {
		se_b = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// 固定テキスト類表示
	public void Th_name(){
		th_name.text = Csute.hero_name;
	}

	public void TE_name(){
		// 相手の名前決める
		rand_ename = Random.Range(0,857);
		string[] e_list = csv.text.Split("\n"[0]);
		e_name = e_list [rand_ename];
		te_name.text = e_name;
	}

	public void Battle_youi(){
		turn = 0;
		go_ikusei_main = false;
		go_next_battle = false;
		yusyou = false;
			// 相手戦闘力決める
			if (Csute.hero_lank == 1) {
				if (Csute.syu ==1 ){
					e_hp = Random.Range(110,146);
					e_kou = Random.Range(41,63);
					e_bou = Random.Range(12,24);
					e_hit = Random.Range(75,95);
					e_kai = Random.Range(0,6);
					e_cri = Random.Range(0,3);
					e_agi = Random.Range(79,110);
					
				}else if(Csute.syu ==2 ){
					e_hp = Random.Range(123,161);
					e_kou = Random.Range(46,70);
					e_bou = Random.Range(15,26);
					e_hit = Random.Range(78,98);
					e_kai = Random.Range(1,7);
					e_cri = Random.Range(0,3);
					e_agi = Random.Range(84,116);
					
				}else if(Csute.syu ==3 ){
					e_hp = Random.Range(138,184);
					e_kou = Random.Range(52,78);
					e_bou = Random.Range(18,29);
					e_hit = Random.Range(82,104);
					e_kai = Random.Range(1,8);
					e_cri = Random.Range(0,4);
					e_agi = Random.Range(90,122);
					
				}else if(Csute.syu ==4 ){
					e_hp = Random.Range(153,198);
					e_kou = Random.Range(58,85);
					e_bou = Random.Range(21,33);
					e_hit = Random.Range(85,106);
					e_kai = Random.Range(1,9);
					e_cri = Random.Range(0,5);
					e_agi = Random.Range(94,125);
					
				}else if(Csute.syu ==5 ){
					e_hp = Random.Range(250,300);
					e_kou = Random.Range(59,87);
					e_bou = Random.Range(22,35);
					e_hit = Random.Range(87,107);
					e_kai = Random.Range(0,10);
					e_cri = Random.Range(0,5);
					e_agi = Random.Range(98,129);
					
				}
			}else if (Csute.hero_lank == 2) {
				if (Csute.syu ==1 ){
					e_hp = Random.Range(210,248);
					e_kou = Random.Range(72,94);
					e_bou = Random.Range(30,42);
					e_hit = Random.Range(90,110);
					e_kai = Random.Range(3,10);
					e_cri = Random.Range(0,3);
					e_agi = Random.Range(106,130);
					
				}else if(Csute.syu ==2 ){
					e_hp = Random.Range(235,274);
					e_kou = Random.Range(79,102);
					e_bou = Random.Range(33,44);
					e_hit = Random.Range(93,112);
					e_kai = Random.Range(4,11);
					e_cri = Random.Range(0,3);
					e_agi = Random.Range(110,135);
					
				}else if(Csute.syu ==3 ){
					e_hp = Random.Range(259,301);
					e_kou = Random.Range(88,110);
					e_bou = Random.Range(36,47);
					e_hit = Random.Range(94,118);
					e_kai = Random.Range(5,12);
					e_cri = Random.Range(0,4);
					e_agi = Random.Range(113,140);
					
				}else if(Csute.syu ==4 ){
					e_hp = Random.Range(284,333);
					e_kou = Random.Range(95,115);
					e_bou = Random.Range(41,50);
					e_hit = Random.Range(98,120);
					e_kai = Random.Range(5,13);
					e_cri = Random.Range(0,4);
					e_agi = Random.Range(118,143);
					
				}else if(Csute.syu ==5 ){
					e_hp = Random.Range(380,450);
					e_kou = Random.Range(97,118);
					e_bou = Random.Range(43,53);
					e_hit = Random.Range(101,121);
					e_kai = Random.Range(5,13);
					e_cri = Random.Range(0,5);
					e_agi = Random.Range(120,145);
					
				}
			}else if (Csute.hero_lank == 3) {
				if (Csute.syu ==1 ){
					e_hp = Random.Range(352,397);
					e_kou = Random.Range(108,129);
					e_bou = Random.Range(48,60);
					e_hit = Random.Range(106,127);
					e_kai = Random.Range(6,14);
					e_cri = Random.Range(0,3);
					e_agi = Random.Range(128,148);
					
				}else if(Csute.syu ==2 ){
					e_hp = Random.Range(388,446);
					e_kou = Random.Range(114,138);
					e_bou = Random.Range(50,63);
					e_hit = Random.Range(109,131);
					e_kai = Random.Range(6,15);
					e_cri = Random.Range(0,4);
					e_agi = Random.Range(133,154);
					
				}else if(Csute.syu ==3 ){
					e_hp = Random.Range(428,500);
					e_kou = Random.Range(121,152);
					e_bou = Random.Range(52,66);
					e_hit = Random.Range(111,135);
					e_kai = Random.Range(7,17);
					e_cri = Random.Range(0,4);
					e_agi = Random.Range(139,162);
					
				}else if(Csute.syu ==4 ){
					e_hp = Random.Range(475,555);
					e_kou = Random.Range(127,160);
					e_bou = Random.Range(55,68);
					e_hit = Random.Range(114,139);
					e_kai = Random.Range(8,17);
					e_cri = Random.Range(0,5);
					e_agi = Random.Range(146,170);
					
				}else if(Csute.syu ==5 ){
					e_hp = Random.Range(600,740);
					e_kou = Random.Range(130,162);
					e_bou = Random.Range(58,71);
					e_hit = Random.Range(115,140);
					e_kai = Random.Range(10,18);
					e_cri = Random.Range(2,6);
					e_agi = Random.Range(148,171);
				}
				
			}else if (Csute.hero_lank == 4) {
				if (Csute.syu ==1 ){
					e_hp = Random.Range(580,698);
					e_kou = Random.Range(145,174);
					e_bou = Random.Range(65,78);
					e_hit = Random.Range(118,142);
					e_kai = Random.Range(8,17);
					e_cri = Random.Range(0,4);
					e_agi = Random.Range(151,174);
					
				}else if(Csute.syu ==2 ){
					e_hp = Random.Range(643,726);
					e_kou = Random.Range(151,180);
					e_bou = Random.Range(67,74);
					e_hit = Random.Range(120,145);
					e_kai = Random.Range(10,18);
					e_cri = Random.Range(0,4);
					e_agi = Random.Range(154,178);
					
				}else if(Csute.syu ==3 ){
					e_hp = Random.Range(688,782);
					e_kou = Random.Range(155,186);
					e_bou = Random.Range(69,77);
					e_hit = Random.Range(123,147);
					e_kai = Random.Range(10,19);
					e_cri = Random.Range(0,5);
					e_agi = Random.Range(158,182);
					
				}else if(Csute.syu ==4 ){
					e_hp = Random.Range(734,825);
					e_kou = Random.Range(162,194);
					e_bou = Random.Range(73,82);
					e_hit = Random.Range(125,152);
					e_kai = Random.Range(10,21);
					e_cri = Random.Range(0,6);
					e_agi = Random.Range(160,185);
					
				}else if(Csute.syu ==5 ){
					e_hp = Random.Range(850,999);
					e_kou = Random.Range(165,200);
					e_bou = Random.Range(75,85);
					e_hit = Random.Range(126,155);
					e_kai = Random.Range(10,22);
					e_cri = Random.Range(1,7);
					e_agi = Random.Range(162,185);
				}
				
			}else if (Csute.hero_lank == 5) {
				if (Csute.syu ==1 ){
					e_hp = Random.Range(830,912);
					e_kou = Random.Range(174,208);
					e_bou = Random.Range(82,101);
					e_hit = Random.Range(131,156);
					e_kai = Random.Range(8,20);
					e_cri = Random.Range(0,4);
					e_agi = Random.Range(170,195);
					
				}else if(Csute.syu ==2 ){
					e_hp = Random.Range(880,1000);
					e_kou = Random.Range(184,220);
					e_bou = Random.Range(85,106);
					e_hit = Random.Range(134,160);
					e_kai = Random.Range(9,23);
					e_cri = Random.Range(0,5);
					e_agi = Random.Range(174,200);
					
				}else if(Csute.syu ==3 ){
					e_hp = Random.Range(950,1120);
					e_kou = Random.Range(198,240);
					e_bou = Random.Range(90,114);
					e_hit = Random.Range(137,165);
					e_kai = Random.Range(10,24);
					e_cri = Random.Range(0,6);
					e_agi = Random.Range(179,207);
					
				}else if(Csute.syu ==4 ){
					e_hp = Random.Range(1050,1240);
					e_kou = Random.Range(209,250);
					e_bou = Random.Range(96,122);
					e_hit = Random.Range(139,168);
					e_kai = Random.Range(11,25);
					e_cri = Random.Range(0,6);
					e_agi = Random.Range(185,214);
					
				}else if(Csute.syu ==5 ){
					e_hp = Random.Range(1400,1700);
					e_kou = Random.Range(220,260);
					e_bou = Random.Range(100,130);
					e_hit = Random.Range(140,170);
					e_kai = Random.Range(12,28);
					e_cri = Random.Range(2,7);
					e_agi = Random.Range(190,220);
				}
				
			}else if (Csute.hero_lank == 6) {
				if (Csute.syu ==1 ){
					e_hp = Random.Range(1200,1500);
					e_kou = Random.Range(250,300);
					e_bou = Random.Range(120,160);
					e_hit = Random.Range(145,180);
					e_kai = Random.Range(10,26);
					e_cri = Random.Range(0,5);
					e_agi = Random.Range(220,260);
					
				}else if(Csute.syu ==2 ){
					e_hp = Random.Range(1400,1750);
					e_kou = Random.Range(275,330);
					e_bou = Random.Range(130,163);
					e_hit = Random.Range(148,185);
					e_kai = Random.Range(11,28);
					e_cri = Random.Range(1,6);
					e_agi = Random.Range(235,280);
					
				}else if(Csute.syu ==3 ){
					e_hp = Random.Range(1700,2100);
					e_kou = Random.Range(305,360);
					e_bou = Random.Range(140,175);
					e_hit = Random.Range(155,190);
					e_kai = Random.Range(12,29);
					e_cri = Random.Range(1,7);
					e_agi = Random.Range(250,300);
					
				}else if(Csute.syu ==4 ){
					e_hp = Random.Range(2000,2600);
					e_kou = Random.Range(340,400);
					e_bou = Random.Range(150,188);
					e_hit = Random.Range(158,192);
					e_kai = Random.Range(12,30);
					e_cri = Random.Range(2,8);
					e_agi = Random.Range(270,325);
					
				}else if(Csute.syu ==5 ){
					e_hp = Random.Range(3000,5000);
					e_kou = Random.Range(380,460);
					e_bou = Random.Range(160,200);
					e_hit = Random.Range(160,200);
					e_kai = Random.Range(13,32);
					e_cri = Random.Range(2,10);
					e_agi = Random.Range(300,360);
				}
			}
			h_hp = Csute.hero_HP;
			en_hp = e_hp;
			battle_end = false;
			syourihantei = 0;
	}

	public void Battle_Naibu(){

		// 行動順決める
		koudou_hantei = Csute.hero_Agi+e_agi;
		if (turn == 1){
			h_koudou = koudou_hantei;
			e_koudou = koudou_hantei;
		}
		
		while (h_koudou > 0 && e_koudou >0){
			h_koudou -= Csute.hero_Agi;
			e_koudou -= e_agi;	
		}


		if(turn<=40){
		//主人公の方が早かったら主人公の攻撃
			if (h_koudou <= e_koudou && battle_end == false){
				kougekigawa =1;
				// 命中処理
				hit_or_miss = Random.Range(0,100)+e_kai;
				if (Csute.hero_Hit >= hit_or_miss){
					h_miss = false;
					// ダメージ基本
					e_dame = Csute.hero_Kougeki - e_bou;
					if(e_dame < 0){
						e_dame = 0;
					}

					// 会心処理
					kaisin = Random.Range(0,100)+ Csute.hero_Crit;
					if (kaisin >= 100){
						e_dame *= 2;
						se_b.PlayOneShot(crit);
					} else if (kaisin<100){
						se_b.PlayOneShot(hit);
					}

					// ダメージ処理
					en_hp -= e_dame;

					//勝敗判定
					if (en_hp <=0){
						syourihantei = 1;
						battle_end = true;
					}
					}else if(Csute.hero_Hit < hit_or_miss){
						h_miss = true;
					}
					// 耐えたら次の行動順
				h_koudou = koudou_hantei;
					
			}else if (h_koudou > e_koudou && e_koudou <= 0 && battle_end == false){
				kougekigawa +=2;
				// 命中処理
				hit_or_miss = Random.Range(0,100)+Csute.hero_Kaihi;
				if (e_hit >= hit_or_miss){
					e_miss = false;
					// ダメージ基本
					h_dame = e_kou - Csute.hero_Bougyo;
						if(h_dame < 0){
							h_dame = 0;
						}
					// 会心処理
					kaisin = Random.Range(0,100)+ e_cri;
						if (kaisin >= 100){
							h_dame *= 2;
						se_b.PlayOneShot(crit);
						} else if (kaisin<100){
						se_b.PlayOneShot(hit);
					}
						// ダメージ処理
						h_hp -= h_dame;
						
						//勝敗判定
						if (h_hp <=0){
							battle_end = true;
							syourihantei = 2;
						}
					}else if(e_hit < hit_or_miss){
					e_miss = true;
					}
					// 耐えたら次の行動順
					e_koudou = koudou_hantei;
				}

			if(battle_end == true){
				b_e_count++;
			}else if(battle_end == false){
				b_e_count=0;
			}
		}else if (turn>40){
			if(h_hp>=en_hp){
				syourihantei=1;
			}else if(h_hp<en_hp){
				syourihantei=2;
			}
			battle_end = true;
		}
	}

	// ＨＰ表示
	public void H_HPhyozi(){
		th_hp.text = h_hp + "/" + Csute.hero_HP; 
	}

	public void E_HPhyozi(){
		te_hp.text = en_hp + "/" + e_hp; 
	}

	public void H_HP_Gage(){
		float h_mhp_f = Csute.hero_HP;
		float h_nhp_f=h_hp;
		h_gage_keisan = h_nhp_f / h_mhp_f;
		h_hp_gage.value = h_gage_keisan ;
	}

	public void E_HP_Gage(){
		float e_mhp_f2=e_hp;
		float e_nhp_f2=en_hp;
		e_gage_keisan = e_nhp_f2 / e_mhp_f2 + 0.0000f;
		e_hp_gage.value = e_gage_keisan ;
	}
	// テキスト
	public void B_Text(){
		if (battle_end == false){
			if(kougekigawa==1){
				if (h_miss == false){
				battle_text.text = Csute.hero_name + "の攻撃！\n" + e_name + "に" + e_dame + "のダメージ！";
				}else if(h_miss == true){
					battle_text.text = Csute.hero_name +"は攻撃を外した！";
				}
			}else if(kougekigawa==2){
				if(e_miss == false){
				battle_text.text = e_name + "の攻撃！\n" + Csute.hero_name + "に" + h_dame + "のダメージ！";
				}else if(e_miss == true){
					battle_text.text = e_name +"は攻撃を外した！";
				}
			}else if(kougekigawa==3){
				if(h_miss==true && e_miss ==true){
					battle_text.text = Csute.hero_name +"は攻撃を外した！\n\n" + e_name +"は攻撃を外した！";
				}else if (h_miss==true && e_miss ==false){
					battle_text.text = Csute.hero_name +"は攻撃を外した！\n\n" + e_name + "の攻撃！\n" + Csute.hero_name + "に" + h_dame + "のダメージ！";
				}else if (h_miss==false && e_miss ==true){
					battle_text.text = Csute.hero_name + "の攻撃！\n" + e_name + "に" + e_dame + "のダメージ！\n\n" + e_name +"は攻撃を外した！";
				}else if (h_miss==false && e_miss ==false){
				battle_text.text = Csute.hero_name + "の攻撃！\n" + e_name + "に" + e_dame + "のダメージ！\n\n" + e_name + "の攻撃！\n" + Csute.hero_name + "に" + h_dame + "のダメージ！";
				}
			}

		}else if(battle_end == true) {
			if (syourihantei==1){
				battle_text.text = Csute.hero_name + "の攻撃！\n" + e_name + "に" + e_dame + "のダメージ！\n\n" + Csute.hero_name + "の勝利！";
				if(b_e_count == 2){
				if (Csute.syu != 5 ){
					go_next_battle = true;
				}else if (Csute.syu == 5){
					yusyou = true;
				}
				}
			}else if(syourihantei == 2){

				battle_text.text = e_name + "の攻撃！\n" + Csute.hero_name + "に" + h_dame + "のダメージ！\n\n" + e_name + "に負けました……";
				if(b_e_count == 2){
				go_ikusei_main = true;
			}
			}
		}
	}

	//　状況に応じて画面呼び出し
	//　１～４週で勝ったら勝利リザルト呼び出し
	public void w_rizaruto(){

		if (go_next_battle == true){
		this.gameObject.SetActive(true);
		}
	}
	// 優勝したら優勝リザルト呼び出し
	public void y_rizaruto(){

		if(yusyou == true){
		this.gameObject.SetActive(true);
		}
	}

	
	public void battle_del(){
		if(go_ikusei_main == true || go_next_battle == true || yusyou == true){

		this.gameObject.SetActive(false);
		}
	}

	public void comeback_ikusei(){
		if(go_ikusei_main==true){
		this.gameObject.SetActive(true);
		}
	}

	// エンディング

	public void Go_ending(){
		if(Csute.nen==4){
			this.gameObject.SetActive(true);
		}
	}

	// エンディングテキスト
	public void End_text(){
		if(Csute.nen==4){
			if(Csute.hero_lank ==1){
				end_text.text = Csute.hero_name + "の訓練生生活は１回も試合で優勝できずに終わってしまいました。\n" +
					"決して" +Csute.hero_name + "が弱かったのではありません。\n" +
						"正しい訓練と、良き師匠を見つけられればもっと強くなれるでしょう。\n" +
						Csute.hero_name + "の志は次の世代に引き継いで貰いましょう。";
			}else if(Csute.hero_lank ==2){
				end_text.text = Csute.hero_name + "は１回大会で優勝することができました。\n" +
					"平均的な人より才能があるか、質の良い努力をしたのでしょう。" +
						"ただ、良い師匠が居れば話が違うのかもしれません\n" +
						Csute.hero_name + "の志は次の世代に引き継いで貰いましょう。";
			}else if(Csute.hero_lank ==3){
				end_text.text = Csute.hero_name + "はぎりぎり選手としてデビューできるレベルです。\n" +
					"ただし、選手としては下の順位に属するレベルです。\n" +
						"戦闘能力を維持しながら他の仕事も平行しなければなりません。\n" +
						Csute.hero_name + "はコーチをしながら選手をすることにしました。";
			}else if(Csute.hero_lank ==4){
				end_text.text = Csute.hero_name + "は卒業直後としてはかなり力のある選手です。\n" +
					"ただ、上には上が居ます。それも自国や外国を合わせれば膨大な数になるでしょう。\n" +
						Csute.hero_name +"はそんな強大な相手達と戦い続けました。\n" +
						 "しばらくの選手生活の後、コーチに就任することになります。";
			}else if(Csute.hero_lank ==5){
				end_text.text = Csute.hero_name + "は大物新人選手となりました。\n" +
					"選手生活１年目にして上位リーグでの戦いに行く事になります。\n" +
						"一流ではありましたが、引退するまで超一流として伝説になることはありませんでした。\n" +
						Csute.hero_name + "は超一流を目指して訓練生を育てることになります。";
			}else if(Csute.hero_lank ==6){
				end_text.text = Csute.hero_name + "は戦いの天才です。\n" +
					"選手になった直後から一流選手と互角の戦いをして、国家を代表する選手として戦い続けます。\n" +
						"祖国の観光計画を大いに盛り上げ、国家の英雄になります。\n" +
						Csute.hero_name + "は引退後、新たに訓練所を作り優秀な弟子達を排出し続けます。\n" +
						Csute.hero_name +"は歴史を変えました！";
			}
		}
	}

	public void battle_lang_kai(){
		taikaibs.text = "ランク" + Csute.hero_lank + "：" + Csute.syu + "戦目" ;
	}
}
