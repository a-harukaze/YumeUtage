using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinRezalt : MonoBehaviour {
	static int wr_kinup;
	static int wr_magup;
	static int wr_binup;
	static int wr_menup;
	static int wr_seiup;

	public Text rpupkin;
	public Text rpupmag;
	public Text rpupbin;
	public Text rpupmen;
	public Text rpupsei;

	public Text lankup;
	public Text end_text;
	public Text timehyouzi;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// 成長ポイント入手
	public void Rpup(){
		if(BattleMain.go_next_battle == true){
		if(Csute.syu != 5){
		wr_kinup = (Csute.hero_lank*10)+ Random.Range(Csute.syu,Csute.syu*3);
		wr_magup = (Csute.hero_lank*10)+ Random.Range(Csute.syu,Csute.syu*3);
		wr_binup = (Csute.hero_lank*10)+ Random.Range(Csute.syu,Csute.syu*3);
		wr_menup = (Csute.hero_lank*10)+ Random.Range(Csute.syu,Csute.syu*3);
		wr_seiup = (Csute.hero_lank*10)+ Random.Range(Csute.syu,Csute.syu*3);
			}else{
			wr_kinup = (Csute.hero_lank*12)+ Random.Range(Csute.syu,Csute.syu*3);
			wr_magup = (Csute.hero_lank*12)+ Random.Range(Csute.syu,Csute.syu*3);
			wr_binup = (Csute.hero_lank*12)+ Random.Range(Csute.syu,Csute.syu*3);
			wr_menup = (Csute.hero_lank*12)+ Random.Range(Csute.syu,Csute.syu*3);
			wr_seiup = (Csute.hero_lank*12)+ Random.Range(Csute.syu,Csute.syu*3);
		}
		}
	 if (BattleMain.go_ikusei_main == true){
			wr_kinup = (Csute.hero_lank*5)+ Random.Range(0,Csute.syu*2);
			wr_magup = (Csute.hero_lank*5)+ Random.Range(0,Csute.syu*2);
			wr_binup = (Csute.hero_lank*5)+ Random.Range(0,Csute.syu*2);
			wr_menup = (Csute.hero_lank*5)+ Random.Range(0,Csute.syu*2);
			wr_seiup = (Csute.hero_lank*5)+ Random.Range(0,Csute.syu*2);
		}

	}

	// 上昇値表示
	public void Rpupkin(){
		if(BattleMain.go_next_battle == true || BattleMain.go_ikusei_main == true){
		rpupkin.text =wr_kinup + "↑";
		Csute.hero_Kin += wr_kinup;
		}
	}
	public void Rpupmag(){
		if(BattleMain.go_next_battle == true || BattleMain.go_ikusei_main == true){
		rpupmag.text =wr_magup + "↑";
		Csute.hero_Mag += wr_magup;
		}
	}
	public void Rpupbin(){
		if(BattleMain.go_next_battle == true || BattleMain.go_ikusei_main == true){
		rpupbin.text =wr_binup + "↑";
		Csute.hero_Bin += wr_binup;
		}
	}
	public void Rpupmen(){
		if(BattleMain.go_next_battle == true || BattleMain.go_ikusei_main == true){
		rpupmen.text =wr_menup + "↑";
		Csute.hero_Men += wr_menup;
		}
	}
	public void RpupSei(){
		if(BattleMain.go_next_battle == true || BattleMain.go_ikusei_main == true){
		rpupsei.text =wr_seiup + "↑";
		Csute.hero_Sei += wr_seiup;
		}
	}

	// 優勝上昇値表示
	public void YRpupkin(){
		if(BattleMain.yusyou == true){
		rpupkin.text =wr_kinup + "↑";
		Csute.hero_Kin += wr_kinup;
		}
	}
	public void YRpupmag(){
		if(BattleMain.yusyou == true){
		rpupmag.text =wr_magup + "↑";
		Csute.hero_Mag += wr_magup;
		}
	}
	public void YRpupbin(){
		if(BattleMain.yusyou == true){
		rpupbin.text =wr_binup + "↑";
		Csute.hero_Bin += wr_binup;
		}
	}
	public void YRpupmen(){
		if(BattleMain.yusyou == true){
		rpupmen.text =wr_menup + "↑";
		Csute.hero_Men += wr_menup;
		}
	}
	public void YRpupSei(){
		if(BattleMain.yusyou == true){
		rpupsei.text =wr_seiup + "↑";
		Csute.hero_Sei += wr_seiup;
		}
	}
	
	//次の画面へ

	public void Go_IkuseiMain(){
		Csute.syu = 1;
			if(Csute.tuki == 6){
				Csute.tuki = 7;
			}else if (Csute.tuki == 12){
				Csute.tuki =1;
				Csute.nen +=1;
			}
			if(Csute.nen !=4){
			this.gameObject.SetActive(true);
		}
	}

	public void Go_Nextbattle(){
		if(Csute.syu != 5){
			Csute.syu += 1;
		this.gameObject.SetActive(true);
		}
	}

	public void WR_off(){
		this.gameObject.SetActive(false);
	}

	// ランクアップ
	public void LankUP(){
		if(BattleMain.yusyou == true){
		Csute.hero_lank ++;
		lankup.text="ランクアップ！\n現在ランク："+ Csute.hero_lank;
		}
	}

	// ４年目になったらエンディングへ
	public void Ending_Event(){
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
				end_text.text = Csute.hero_name + "はデビューとしてはそれなりの実力です。\n" +
					"同期相手にも苦戦を続けて、選手としても平均レベルまで成長しました。。\n" +
						Csute.hero_name +"は国内ではそれなりに食べていけますが、外国では活躍できないとわかりました。\n" +
						"しばらくの選手生活の後、コーチに就任することになります。";
			}else if(Csute.hero_lank ==5){
				end_text.text = Csute.hero_name + "は卒業直後としてはかなり力のある選手です。\n" +
					"ただ、上には上が居ます。それも自国や外国を合わせれば膨大な数になるでしょう。\n" +
						Csute.hero_name +"はそんな強大な相手達と戦い続けました。\n" +
						"しばらくの選手生活の後、コーチに就任することになります。";
			}else if(Csute.hero_lank ==6){
				end_text.text = Csute.hero_name + "は大物新人選手となりました。\n" +
					"選手生活１年目にして上位リーグでの戦いに行く事になります。\n" +
						"一流ではありましたが、引退するまで超一流として伝説になることはありませんでした。\n" +
						Csute.hero_name + "は超一流を目指して訓練生を育てることになります。";
			}else if(Csute.hero_lank ==7){
				end_text.text = Csute.hero_name + "は戦いの天才です。\n" +
					"選手になった直後から一流選手と互角の戦いをして、国家を代表する選手として戦い続けます。\n" +
						"祖国の観光計画を大いに盛り上げ、国家の英雄になります。\n" +
						Csute.hero_name + "は引退後、新たに訓練所を作り優秀な弟子達を排出し続けます。\n" +
						Csute.hero_name +"は歴史を変えました！";
			}
		}
	}

	public void Ftimehyouzi(){
		timehyouzi.text = Csute.nen + "年目" + Csute.tuki + "月" + Csute.syu + "週";
	}
}
