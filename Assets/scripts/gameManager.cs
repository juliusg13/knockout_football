using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {

    public float time;
    public GameObject UI;
    public GameObject timeUI;
    public GameObject scoreLeft, scoreRight;
    Text timeText, scoreLeftText, scoreRightText;
    public int scoreA, scoreB;
    string message;

    // Use this for initialization
    void Start () {
        scoreA = 0;
        scoreB = 0;
        timeText = timeUI.GetComponent<Text>();
        scoreLeftText = scoreLeft.GetComponent<Text>();
        scoreRightText = scoreRight.GetComponent<Text>();

        timeText.text = "Time: " + time.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        timeText.text = "Time: " + time;
        
        if (time <= 0) {
            gameOver();
        }
        timeText.text = "Time: " + time.ToString();
        scoreLeftText.text = "Korea: " + scoreA.ToString();
        scoreRightText.text = "Iceland: " + scoreB.ToString();
    }

    void gameOver() {
        if(scoreA > scoreB) {
            message = "North Korea wins! Nukes for everybody.";
        } else if(scoreB > scoreA) {
            message = "Iceland wins! Enjoy some decomposed shark.";
        } else {
            message = "It's a tie, trophy will be split into two :(";
        }
        UI.GetComponent<UI>().gameOver(message, 4);

    }

}
