using UnityEngine;
using System.Collections;

public class EnemyDeath2 : MonoBehaviour {
	public GameObject whiteCam;
        // Use this for initialization
        void Start () {
        
        }
        
        // Update is called once per frame
        void Update () {
        
        }
        
        void OnTriggerEnter(Collider other) {
        if (other.tag == "Enemy" ){        
		transform.position = new Vector3(-121f , 7f, 247f);
		}

		if (other.tag == "Edison") {
			//StartCoroutine(Delay());
			whiteCam.renderer.enabled = true;
			Application.LoadLevel("GroundGun");
		}
	}

		//IEnumerator Delay() {
		//yield return WaitForSeconds(2f);
	//}
            
        


}