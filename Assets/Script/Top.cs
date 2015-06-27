using UnityEngine;
using System.Collections;

public class Top : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Csute.savekaisuu = PlayerPrefs.GetInt ("s_savekaisuu", 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Topend(){
		gameObject.SetActive (false);
	}

	public void TitleON(){
		gameObject.SetActive (true);
	}

	public void LoadOK(){
		if (Csute.savekaisuu != 0) {
			gameObject.SetActive (true);
		}
	}

	public void LoadNG(){
		if (Csute.savekaisuu == 0) {
			gameObject.SetActive (true);
		}
	}
}
