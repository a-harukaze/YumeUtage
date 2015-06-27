using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ToreKaku : MonoBehaviour {
	public Text timekousin;
	public Text timekousin2;
	public Text taikaitextf;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// 時間経過
	public void Timekousin(){
			if (Csute.syu == 5) {
				Csute.tuki ++;
				Csute.syu = 1;
			} else {
				Csute.syu += 1;
			}
			timekousin.text = Csute.nen + "年目" + Csute.tuki + "月" + Csute.syu + "週";
	}

	// 育成メイン画面出す
	public void IMOpen(){
		if (Csute.tuki == 1 || Csute.tuki == 2 || Csute.tuki == 3 || Csute.tuki == 4 || Csute.tuki == 5 || Csute.tuki == 7 || Csute.tuki == 8 || Csute.tuki == 9 || Csute.tuki == 10 || Csute.tuki == 11) {
			this.gameObject.SetActive (true);
		}
	}

	// 育成リザルトオフ
	public void IRoff(){
		this.gameObject.SetActive (false);
	}

	// 大会画面呼び出す
	public void ClooTaikai(){
		if(Csute.tuki ==6 || Csute.tuki ==12){
			this.gameObject.SetActive (true);
		}
	}

	// 大会時の時間表示
	public void TaikaiTime(){
			timekousin2.text = Csute.nen + "年目" + Csute.tuki + "月" + Csute.syu + "戦目";
	}

	// 大会でのテキスト
	public void Taikaitext_f(){
		taikaitextf.text = "今月も始まりました訓練生武道大会！\nこれよりランク"+Csute.hero_lank+"の第１戦目が\n始まります！";
	}
}
