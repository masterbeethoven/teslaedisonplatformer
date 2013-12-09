using UnityEngine;
using System.Collections;

public class SentinalAnimation : MonoBehaviour {
	public Rigidbody myRigidbody;
	public float rayLength = 20f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	Ray ray = new Ray (transform.position, transform.forward);
	RaycastHit rayHit = new RaycastHit();

	Physics.Raycast(ray, out rayHit, rayLength);
		//check to see if it hits the player somehow
	if (rayHit.collider.tag == "Player"){
		
		//transform.Translate(transform.forward.normalized * Time.deltaTime * speed);
		animation.CrossFade( "SentWalk" );
		}

	
	}
}
