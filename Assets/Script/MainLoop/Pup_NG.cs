using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pup_NG : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	//育成画面戻る
	public void IMON(){
		this.gameObject.SetActive (true);
	}

	//成長画面消す
	public void PUPPG_OFF(){
		this.gameObject.SetActive (false);
	}
}
