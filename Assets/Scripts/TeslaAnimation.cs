using UnityEngine;
using System.Collections;

public class TeslaAnimation : MonoBehaviour {

	Vector3 inputVector;
	public float speed = 10f;
	public float jumpSpeed = 10f;
	private Vector3 startPosition;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		inputVector = Vector3.zero;
//	
//		if ( Input.GetAxis("Vertical" ) > 0) { // MOVE FORWARD
//            inputVector += transform.forward; // transform.forward does NOT move anything, it is just a variable we read
//        }
//		
//        if ( Input.GetAxis("Vertical" ) < 0) { // MOVE BACKWARD
//            inputVector += -transform.forward;
//        }
//		
		float walk = Input.GetAxis("Horizontal") * speed;
		float jump = Input.GetAxis ("Jump") * jumpSpeed;
        walk *= Time.deltaTime;
		jump *= Time.deltaTime;
        transform.Translate(0, 0, walk);
		transform.Translate(0, jump, 0);
		
		bool grounded = Physics.Raycast( transform.position, -transform.up, 1f );
		if ( grounded == true ) {
            if ( Input.GetKeyDown( KeyCode.UpArrow )) {
//				audio.Play ();
				animation.CrossFade( "Jump" );
                //inputVector += Vector3.up * jumpSpeed;
            }
        }
	}
	
	void FixedUpdate () {
		if ( inputVector != Vector3.zero ) {
            animation.CrossFade ("Walk");
		}
			else{
			animation.CrossFade ("Idle");
			}
	
			//rigidbody.AddForce( inputVector, ForceMode.VelocityChange );
        }
    }

