using UnityEngine;
using System.Collections;

public class SineFlash : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		renderer.enabled = false;

		
		if(Mathf.Sin(Time.time * 75f) > .8f)
		{
			renderer.enabled = true;
		}
		
		transform.localScale += new Vector3(Mathf.Sin (Time.time*10f), Mathf.Sin (Time.time*10f), Mathf.Sin (Time.time*10f)) * .08f;
	}
}
