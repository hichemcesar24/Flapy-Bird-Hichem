using UnityEngine;
using System.Collections;

public class tap : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.gameStart)
						GetComponent<Renderer>().enabled = false;
	
	}
}
