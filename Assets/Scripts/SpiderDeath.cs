using UnityEngine;
using System.Collections;

public class SpiderDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter() {
		transform.position = new Vector3 (32f, 3f, 10f);
	}
}
