using UnityEngine;
using System.Collections;

public class BulletControl : MonoBehaviour {
        
        bool bulletBool = false;
        float bulletTime;
        
        // Use this for initialization
        void Start () {
        
        }
        
        // Update is called once per frame
        void Update () {
                if (bulletBool == false) {
                        bulletTime = Time.time;
                        bulletBool = true;
                        //Debug.Log ("TimerStart");
                }
                if ((bulletBool == true) && ((bulletTime + 0.9f) < Time.time)) {
                        //Debug.Log ("Destorying");
                        transform.localScale -= new Vector3(0f, 1f, 0f);
                        Destroy(gameObject);
                }
        }
        
        void OnTriggerEnter(Collider other) {
                if (other.tag == "Wall" || other.tag == "Enemy") {
                        //Debug.Log("Wall hit");
                        Destroy (gameObject);
                }
                //if (other.tag == "Enemy") {
                        //Debug.Log ("Supressing Fire!");
						//Destroy (other.gameObject);
               // }
        }
}