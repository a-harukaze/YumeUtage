using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class UDS : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Advertisement.Initialize ("48281");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void UnityAds(){
		// Unity Adsを表示する準備ができているか確認する
		if (Advertisement.isReady ()) {
			// Unity Adsを表示する
			Advertisement.Show ();
		}
	}
}
