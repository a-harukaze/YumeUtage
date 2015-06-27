using UnityEngine;
using System.Collections;
using System;

public class SE : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void BGMon(){
		if(Csute.nen!=4){
		this.gameObject.SetActive(true);
			DontDestroyOnLoad(this.gameObject);
		}
	}

	public void BGMoff(){
		this.gameObject.SetActive(false);
	}

	public void EDBGMon(){
		if(Csute.nen ==4){
			this.gameObject.SetActive(true);
			DontDestroyOnLoad(this.gameObject);
		}
	}

	public void BBGMon(){
		if(Csute.tuki==6 || Csute.tuki==12){
			this.gameObject.SetActive(true);
			DontDestroyOnLoad(this.gameObject);
		}
	}

	public void BOBGMoff(){
		if(Csute.tuki==6 || Csute.tuki==12){
			this.gameObject.SetActive(false);
			DontDestroyOnLoad(this.gameObject);
		}
	}
}
