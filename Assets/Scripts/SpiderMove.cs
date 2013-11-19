using UnityEngine;
using System.Collections;

public class SpiderMove : MonoBehaviour {
	
	public float rayLength = 20f;
	public float speed = .5f;
	float timer = 0f;
	public float animateDelay = 2f;
	public float turnDelay = 5f;
	int direction = 1;
	
	// Use this for initialization
	void Start () {
	
	}
	
	void FixedUpdate () {
		
//		This section controls the movement based on raycasts
//		
//		Ray ray = new Ray (transform.position, transform.forward);
//		RaycastHit rayHit = new RaycastHit();
		
//	    transform.Translate(transform.forward.normalized * Time.deltaTime * speed * direction);
		
//		if(Physics.Raycast(ray, out rayHit, rayLength)) 
//		{
//				transform.Rotate(Vector3.up, 180f);
//				direction *= -1;
//		}		
		
//		This section controls the movement based on a timer		
		//animation.CrossFade( "SpiderWalk" );
		if(Time.time - timer > animateDelay)
		{
		    transform.Translate(transform.right.normalized * Time.deltaTime * speed * direction);
			//animation.CrossFade( "SpiderWalk" );
		}
		
		if(Time.time - timer > turnDelay)
		{
			//animation.CrossFade( "SpiderWalk" );
			timer = Time.time;
			direction *= -1;
			transform.Rotate (Vector3.up, 180f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		//animation.CrossFade( "SpiderWalk" );
	
	}
}
