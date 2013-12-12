using UnityEngine;
using System.Collections;

public class SpiderAnimation : MonoBehaviour {
	
	public Rigidbody myRigidbody;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		animation.Play("SpiderWalk");
	
	}
}
