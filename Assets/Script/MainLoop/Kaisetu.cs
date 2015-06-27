using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Kaisetu : MonoBehaviour {
	public Text kaisetu1;
	public Text kaisetu2;
	static int kid;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			kid++;
		}
	}

	public void KaisetuOpen(){
		this.gameObject.SetActive (true);
	}

	public void KaisetuClose(){
		if (kid == 27) {
			this.gameObject.SetActive (false);
		}
	}

	public void Kaisetu1(){
		if (kid == 3){
			kaisetu1.text ="遊び方\n\n" +
				"２．ゲームの流れ\n" +
					"６ヶ月に１回大会があり、\n" +
					"６回目の大会を終えたらエンディングです。\n" +
					"１～５月、７～１１月は毎週訓練して、\n" +
					"６月と１２月の大会に備えます。\n\n" +
					"大会の優勝回数によって\n" +
					"エンディングが変わります。\n" +
					"エンディング後は師匠に転身します。\n師匠候補が上限を超えた場合は\n古い師匠から引退していきます。";
		}else if (kid == 6) {
			kaisetu1.text = "遊び方\n\n３．育成パート（１）\nキャラクターをトレーニングさせて\nどんどん強くしていくパートです。\n" +
				"大会で勝利するため、\n６つのトレーニングを使い分けましょう。\n\n" +
				"１．筋トレ：筋力がメインに上がります。\n２．走り込み：敏捷などが上がります。\n３．攻撃トレ：攻撃の実戦訓練をします。\n" +
				"４．防御トレ：防御の実戦訓練をします。\n５．魔力増幅：主に魔力アップの修行をします。\n６．バランスよく成長します。";
		}else if (kid == 9) {
			kaisetu1.text = "遊び方\n\n３．育成パート（２）\n・各種ステータスの意味・\n育成ステータス\n筋力・魔力・敏捷・精神・精密\n成長時に割り振るためのポイントです。\n\n" +
				"バトルステータス\nＨＰ：耐久力で０になると負けです。\n攻撃力：高いほど相手のＨＰを減らします\n防御力：ＨＰが減りづらくなります\n" +
				"命中力：高いほど相手に当たります。\n回避力：高いほどよけます\n会心力：高いとラッキーヒットが出やすいです\n素早さ：行動が早く回ってきます";
		}else if (kid == 12) {
			kaisetu1.text = "遊び方\n\n４．師匠\nあなた専属のコーチです。\n師匠が居ると訓練の成長値にボーナスがつきます。\n積極的に使いましょう\n" +
				"ゲームスタート時の師匠選択で\n２週目以降に選ぶことができます。\n" +
				"３年たつとあなたのキャラクターは\n師匠兼選手となり、\n次世代の成長をサポートしてくれます。";
		}else if (kid == 15) {
			kaisetu1.text = "遊び方\n\n５．試合\n自動で進みます。\n６月・１２月に大会があり、\n１～４週目に試合を行います。\n" +
				"優勝するとランクが上がり、\n成長率に若干の補正がつきます。";
		}else if (kid == 18) {
			kaisetu1.text = "遊び方\n\n６．成長のコツ\nキャラクター作成時に\n平均型などのタイプを決めましたが、\nそれに沿ったトレーニングが合っています。\n" +
				"パワー型なら筋トレや魔力増幅を、\n高速型なら各種実践トレと走り込みを,\n平均型はバランスよく成長します。\nそうしてあなたのスタイルを見つけてください。";
		}else if (kid == 21) {
			kaisetu1.text = "遊び方\n\n７．エンディング\n３年目１２月の大会で敗北か優勝かでエンディングになります。\n大会に優勝した回数でエンディングが変わりますので、\n" +
				"全部優勝を目指してみてください。\n集会を重ね師匠をパワーアップするごとに\n勝利が楽になります。";
		}else if (kid == 24) {
			kaisetu1.text = "クレジット\n\n制作者：春風　輝（はるかぜ　あきら）\n\nスペシャルサンクス\n制作ツール：ＵＮＩＴＹ\n素材サイト様：\n（各素材サイト様）\nプレイしてくれたあなた";
		}
	}

	public void Kaisetu2(){
		if (kid == 3) {
			kaisetu2.text = "２／９ページ";
		}else if (kid == 6) {
			kaisetu2.text = "３／９ページ";
		}else if (kid == 9) {
			kaisetu2.text = "４／９ページ";
		}else if (kid == 12) {
			kaisetu2.text = "５／９ページ";
		}else if (kid == 15) {
			kaisetu2.text = "６／９ページ";
		}else if (kid == 18) {
			kaisetu2.text = "７／９ページ";
		}else if (kid == 21) {
			kaisetu2.text = "８／９ページ";
		}else if (kid == 24) {
			kaisetu2.text = "９／９ページ";
		}
	}
}
