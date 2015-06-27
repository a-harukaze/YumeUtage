using UnityEngine;
using System.Collections;

public class IkuseiLoadHantei : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
