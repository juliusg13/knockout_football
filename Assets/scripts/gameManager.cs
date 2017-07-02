using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {

    public float time;
    public GameObject timeUI;
    Text timeText;
    int scoreA, scoreB;

	// Use this for initialization
	void Start () {
        scoreA = 0;
        scoreB = 0;
        time = 90;
        timeText = timeUI.GetComponent<Text>();
        timeText.text = "Time: ASDJKH" + time.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        timeText.text = "Time: " + time;
        
        if (time <= 0) {
            gameOver();
        }
        timeText.text = "Time: " + time.ToString();
    }

    void gameOver() {

    }
}
