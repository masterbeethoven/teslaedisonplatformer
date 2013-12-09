using UnityEngine;
using System.Collections;

public class SentinelHealth : MonoBehaviour {

	public int sentinelHP;

	// Use this for initialization
	void Start () {
		sentinelHP = 500;
	}
	
	// Update is called once per frame
	void Update () {
		if (sentinelHP <= 0) {
			//SentinelScript.Die();
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "bullet") {
			sentinelHP -= 5;
		}
	}
}
