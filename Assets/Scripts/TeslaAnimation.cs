using UnityEngine;
using System.Collections;

public class TeslaAnimation : MonoBehaviour {
	

	//Vector3 inputVector;
	//public float speed = 10f;
	//public float jumpSpeed = 10f;
	//private Vector3 startPosition;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//inputVector = Vector3.zero;
//	
//		if ( Input.GetAxis("Vertical" ) > 0) { // MOVE FORWARD
//            inputVector += transform.forward; // transform.forward does NOT move anything, it is just a variable we read
//        }
//		
//        if ( Input.GetAxis("Vertical" ) < 0) { // MOVE BACKWARD
//            inputVector += -transform.forward;
//        }
		bool grounded = Physics.Raycast( transform.position, -transform.up, 1f );
		if ( Input.GetAxis("Horizontal") != 0){
			animation.CrossFade("Walk");
		}		
		
		else if ( grounded == true ) {
            if ( Input.GetKeyDown( KeyCode.UpArrow )) {
//				audio.Play ();
				animation.CrossFade( "Jump" );
                
            }
        }
		else{
			animation.CrossFade ("Idle");
	}
	}
	
	
    }

