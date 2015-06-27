using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SKakuOK(){
		this.gameObject.SetActive (false);
	}

	public void Gstart(){
		this.gameObject.SetActive(true);
	}
}
