using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    GameObject ball;
    Vector2 dir;
    // Use this for initialization
    void Start () {
        ball = GameObject.FindGameObjectWithTag("ball");
        dir = new Vector2(2, 0);
        ball.GetComponent<Rigidbody2D>().AddForce(dir * 5, ForceMode2D.Impulse);
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
