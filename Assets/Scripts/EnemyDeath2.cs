using UnityEngine;
using System.Collections;

public class EnemyDeath2 : MonoBehaviour {

        // Use this for initialization
        void Start () {
        
        }
        
        // Update is called once per frame
        void Update () {
        
        }
        
        void OnTriggerEnter(Collider other) {
        if (other.tag == "Enemy" ){        
		transform.position = new Vector3(-121f , 7f, 175f);
		}
                
        }

}