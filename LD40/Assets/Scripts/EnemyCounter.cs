using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCounter: MonoBehaviour {

        public int counter = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

        public void OnTriggerEnter(Collider other) {
            if (other.tag == "Enemy") {
                counter++;
                Destroy(other.gameObject);
            }
        }
}
