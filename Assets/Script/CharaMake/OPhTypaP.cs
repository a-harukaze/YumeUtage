using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OPhTypaP : MonoBehaviour {
	public Text tbuttontext1;
	public Text tbuttontext2;
	public Text tbuttontext3;
	public Text tbuttontext4;
	public Text tbuttontext5;
	public Text tbuttontext6;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void PTsentaku(){
		this.gameObject.SetActive (false);
	}
	
	public void Teacher_S(){
		Csute.hero_UP_type = "パワー型";
		Csute.hero_Kin_U = 120;
		Csute.hero_Mag_U = 120;
		Csute.hero_Bin_U = 80;
		Csute.hero_Men_U = 100;
		Csute.hero_Sei_U = 80;
		this.gameObject.SetActive (true);
	}

	
	public void Tbutton1(){
		if(Csute.t_kazu >=1){
			this.gameObject.SetActive(true);
		}
	}
	public void Tbutton1text(){
		if(Csute.t_kazu >=1){
			tbuttontext1.text =  "" + Csute.t_name[0];
		}
	}
	
	public void Tbutton2(){
		if(Csute.t_kazu >=2){
			this.gameObject.SetActive(true);
		}
	}
	public void Tbutton2text(){
		if(Csute.t_kazu >=2){
			tbuttontext2.text =  "" + Csute.t_name[1];
		}
	}
	
	public void Tbutton3(){
		if(Csute.t_kazu >=3){
			this.gameObject.SetActive(true);
		}
	}
	public void Tbutton3text(){
		if(Csute.t_kazu >=3){
			tbuttontext3.text =  "" + Csute.t_name[2];
		}
	}
	
	public void Tbutton4(){
		if(Csute.t_kazu >=4){
			this.gameObject.SetActive(true);
		}
	}
	public void Tbutton4text(){
		if(Csute.t_kazu >=4){
			tbuttontext4.text =  "" + Csute.t_name[3];
		}
	}
	
	public void Tbutton5(){
		if(Csute.t_kazu >=5){
			this.gameObject.SetActive(true);
		}
	}
	public void Tbutton5text(){
		if(Csute.t_kazu >=5){
			tbuttontext5.text =  "" + Csute.t_name[4];
		}
	}
	
	public void Tbutton6(){
		if(Csute.t_kazu >=6){
			this.gameObject.SetActive(true);
		}
	}
	public void Tbutton6text(){
		if(Csute.t_kazu >=6){
			tbuttontext6.text =  "" + Csute.t_name[5];
		}
	}
}
