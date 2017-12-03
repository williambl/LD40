using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockRemover : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

        public void OnTriggerExit (Collider other) {
            if (other.tag == "Block") {
                Destroy(other.gameObject);
                Score.rawScore -= 0.5f;
            } else if (other.tag == "Enemy") {
                Destroy(other.gameObject);
                Score.rawScore++;
            }
        }
}
