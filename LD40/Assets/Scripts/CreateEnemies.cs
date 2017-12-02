using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemies : MonoBehaviour {

        public GameObject enemy;
        public AnimationCurve rate;
        int timer = 0;

        Vector3 pos = new Vector3(8.5f, -2.5f, 0f);
        Quaternion rot = Quaternion.Euler(Vector3.zero);

	// Use this for initialization
	void Start () {
	    StartCoroutine(Create ());
	}

        void Update() {
        }
	
	IEnumerator Create () {
            while (true) {
	        Instantiate(enemy, pos, rot);
                timer++;
                yield return new WaitForSeconds(rate.Evaluate(timer));
            }
	}
}
