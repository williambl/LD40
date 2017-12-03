using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

        public Text scoreText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    Score.rawScore += 0.01f;
            Score.score = (int)Score.rawScore - EnemyCounter.counter;
            scoreText.text = Score.score.ToString();
	}
}
