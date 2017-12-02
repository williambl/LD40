using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCounter: MonoBehaviour {

        public int counter = 0;
        public Text countText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

        public void OnTriggerEnter(Collider other) {
            if (other.tag == "Enemy") {
                counter++;
                countText.text = counter.ToString();
                Destroy(other.gameObject);
            }
        }
}
