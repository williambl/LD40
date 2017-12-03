using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

        public Text scoreText;
        public GameObject loseCanvas;
        public Text loseText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
            if (Score.lost)
                return;

	    Score.rawScore += 0.01f;
            Score.score = (int)Score.rawScore - EnemyCounter.counter;
            scoreText.text = Score.score.ToString();

            if (Score.score < 0 || EnemyCounter.counter > 2) {
                Debug.Log("Lost!");
                Score.lost = true;
                loseCanvas.SetActive(true);

                if (Score.score < 0)
                    loseText.text = "Score went negative...";
                else if (EnemyCounter.counter > 2) {
                    loseText.text = "You let too many enemies through!\nScore: " + Score.score;
                }
            }
	}
}
