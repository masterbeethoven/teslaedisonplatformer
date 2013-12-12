using UnityEngine;
using System.Collections;

public class TeslaAnimation : MonoBehaviour {
	bool grounded;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	grounded = Physics.Raycast( transform.position, -transform.up, 2.0f );
		
		if(Input.GetAxis ("Horizontal")  != 0 && grounded){
			animation.CrossFade ("Walk");
		}
		
		else if ( grounded ) {
			if ( Input.GetKeyDown( KeyCode.UpArrow ) || Input.GetKeyDown (KeyCode.W)) 
			{animation.CrossFade ("Jump");}
		}
		
		else{
			animation.CrossFade ("Idle");
		}
	
	
	}	
	
}
