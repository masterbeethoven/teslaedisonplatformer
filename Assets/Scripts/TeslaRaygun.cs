using UnityEngine;
using System.Collections;

public class TeslaRaygun : MonoBehaviour {
        
        //float scaleTrack = 0f;
        //float scaleBeam = 3f;
        float bulletSpeed = 20f;
        public Rigidbody bullet;
		public AudioClip raygunsfx;
        
        // Use this for initialization
        void Start () {
        
        }
        
        // Update is called once per frame
        void Update () {
                /*
                Ray checkRay = new Ray(transform.position,transform.forward);
                RaycastHit checkHit;
                
                if (Input.GetKey(KeyCode.Space)) {
                        Debug.Log ("Firing");
                        if (Physics.Raycast (checkRay, out checkHit, scaleBeam)) {
                                Debug.Log ("Stopped");
                        }
                        if (Physics.Raycast(checkRay, out checkHit, scaleBeam) == false) {
                                Debug.Log("Call Scale");
                                transform.localScale += new Vector3(0f, 0f, 0.5f);
                                scaleBeam += 0.5f;
                                scaleTrack += 0.5f;
                                Debug.Log("Scale");
                        }
                } else {
                        if (scaleTrack >= -0.1f) {
                                transform.localScale -= new Vector3(0f,0f,scaleTrack);
                                scaleTrack -= 0.5f;
                        }
                }
                */
		
			if (Input.GetKeyDown(KeyCode.Space))
				//audio.PlayOneShot(raygunsfx);
			AudioSource.PlayClipAtPoint(raygunsfx, transform.position);
        }
        
        void FixedUpdate() {
                if (Input.GetKey(KeyCode.Space)) {
                        Rigidbody prefabBullet = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
                        prefabBullet.velocity = transform.TransformDirection(new Vector3 (0, 0, bulletSpeed));
                }        
        }
}