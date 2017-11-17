using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continuer_fruit : MonoBehaviour {

    string home = "house";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void continuer() {
        Application.LoadLevel(home);
	}
}
