using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class UI : MonoBehaviour {
    public GameObject winGame;
    // Use this for initialization
    void Start() {
        winGame.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
    }

public void gameOver(string message, float delay) {
        StartCoroutine(ShowMessage(message, delay));
    }
    
private IEnumerator ShowMessage (string message, float delay) {
        winGame.GetComponentInChildren<Text>().text = message;
        winGame.SetActive(true);
        yield return new WaitForSeconds(delay);
        winGame.SetActive(false);
        restart();
 }


public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
