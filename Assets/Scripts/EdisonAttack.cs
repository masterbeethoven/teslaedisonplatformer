using UnityEngine;
using System.Collections;

public class EdisonAttack : MonoBehaviour {

	public float flashDelay = 10f;
	public float flashDuration = 1f;
	public float orbScaleRate = 1f;
	public float shootDelay = 3f;
	public float deltaDelay = 1f;
	public float shootForce = 10f;
	public float deltaForce = 1f;
	public static bool EAttack = false;
	public float rayLength = 20f;
	public GameObject lightbulb;
	public GameObject orb;
	public Transform spawnPoint;
	public AudioClip chargefx;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		orb.renderer.enabled = false;
		//orb.collider.enabled = false;
		if (EAttack == true) {
			audio.PlayOneShot (chargefx);
		orb.transform.localScale += new Vector3(Mathf.Sin (Time.time*10f), Mathf.Sin (Time.time*10f), Mathf.Sin (Time.time*10f)) * orbScaleRate;
		if(Time.time % flashDelay > 0f && Time.time % flashDelay < flashDuration) 
		{
			if(Mathf.Sin(Time.time * 75f) > .8f)
			{
				orb.renderer.enabled = true;
				audio.Stop();
				
				//orb.collider.enabled = true;
			}
			
		}
		}
//		else if (Time.time % flashDelay + shootDelay > 0f && Time.time % shootDelay + 3f < 1f) 
//		{
//			if (Input.GetMouseButtonDown(0)) {
//				Instantiate(ball, transform.position, Quaternion.identity);
//			}
//		}
	}

	IEnumerator BulbThrow()
	{
		while(true)
		{
			yield return new WaitForSeconds(shootDelay);
			GameObject lightbulb1 = Instantiate(lightbulb, spawnPoint.position, Quaternion.identity) as GameObject;
			lightbulb1.rigidbody.AddForce (0f, 0f, shootForce);
			yield return new WaitForSeconds(deltaDelay);
			GameObject lightbulb2 = Instantiate(lightbulb, spawnPoint.position, Quaternion.identity) as GameObject;
			lightbulb2.rigidbody.AddForce (0f, 0f, shootForce + deltaForce);
			yield return new WaitForSeconds(deltaDelay);
			GameObject lightbulb3 = Instantiate(lightbulb, spawnPoint.position, Quaternion.identity) as GameObject;
			lightbulb3.rigidbody.AddForce (0f, 0f, shootForce + 2*deltaForce);
			yield return 0;
		}
	}

	void FixedUpdate() {
		Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit rayHit = new RaycastHit();
	
		if (Physics.Raycast(ray, out rayHit, rayLength) && rayHit.collider.tag == "Player"){ 
			EAttack = true;

		}
	}
}