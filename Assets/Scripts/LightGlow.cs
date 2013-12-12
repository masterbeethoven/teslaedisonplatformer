using UnityEngine;
using System.Collections;

public class LightGlow : MonoBehaviour {

	public float flashDelay = 10f;
	public float scaleRate = 1f;
	public AudioClip explosionfx;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		renderer.enabled = false;
		//collider.enabled = false;

		//change the conditional so that this only happens for a
		//set amount of time after the player dies.  
		if (EdisonAttack.EAttack == true) {
		if(((Time.time + 2f) % flashDelay > 0f) && ((Time.time + 2f) % flashDelay < 2f))
		{
			renderer.enabled = true;
				audio.PlayOneShot (explosionfx);
		
			//collider.enabled = true;
			transform.localScale += new Vector3(1f, 1f, 1f) * scaleRate; 
		}
		}
	}
}
