using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	public float speed = 1f;
	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate()
	{
		Vector3 destination = new Vector3(transform.position.x, transform.position.y, player.transform.position.z - 7f);
//		transform.position += player.transform.position  - transform.position * Time.deltaTime * speed;
		transform.position = Vector3.Lerp(transform.position, destination, Time.deltaTime * speed);
	}
}
