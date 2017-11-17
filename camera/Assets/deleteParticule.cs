using UnityEngine;
using System.Collections;

public class deleteParticule : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject, 1f);
	}
}
