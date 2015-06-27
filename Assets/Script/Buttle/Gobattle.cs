using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gobattle : MonoBehaviour {
	public Text battle_op;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void G_battle(){
		this.gameObject.SetActive (true);
	}

	public void TOoff(){
		this.gameObject.SetActive (false);
	}

	public void B_Text(){
		battle_op.text = "これよりランク" + Csute.hero_lank + "大会\n" + Csute.syu + "回戦を開始します！";
	}
}
