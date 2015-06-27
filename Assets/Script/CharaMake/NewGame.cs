using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NewGame : MonoBehaviour {
	public Text eventtext;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Newgame(){
		this.gameObject.SetActive(false);
	}
	
	public void Opning(){
		this.gameObject.SetActive(true);
		
	}
	
	public void Opning2(){
		eventtext.text = "AS3489年、銀河にある１つの国で" +
			"内戦が終わった。" ;
	}

	public void NonLoadbuttondel(){
		this.gameObject.SetActive(false);
	}
}