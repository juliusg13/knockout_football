using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

    GameObject ball, score;
    public float thrust;
    public Rigidbody2D rb;
    Vector2 vel, target, clamper;
    float magnitude, step;
    public float goalTimer;
    public GameObject score1, score2, gm;
    int scoreA, scoreB;
    bool lockBall, justScored;
    // Use this for initialization
    void Start() {
        ball = GameObject.FindGameObjectWithTag("ball");
        rb = GetComponent<Rigidbody2D>();
        score = GameObject.Find("Score");
        score.SetActive(false);
        lockBall = false;
        justScored = false;
        clamper = new Vector2(1, 1);
    }

    // Update is called once per frame
    void Update() {
        /*   rb.AddForce(transform.right * thrust);
           if (thrust > 0) {
               thrust -= 2;
           }*/
        vel = ball.GetComponent<Rigidbody2D>().velocity;
        Shoot();
        
        magnitude = vel.magnitude;
        //if (magnitude < 1 || magnitude > -1) {
        if(magnitude < clamper.magnitude) { 
            lockBall = false;
//            ball.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            
        }
    }

    void Shoot() {
        if (Input.GetMouseButtonDown(0) && lockBall == false && justScored == false) {
            lockBall = true;
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //            target = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            //            Vector2 origin = Camera.main.WorldToViewportPoint(ball.transform.position);
            Vector2 origin = ball.transform.position;

            rb.velocity = (2 * (target - origin));
            
        }
    }
    /// <summary>
    /// Should pause time when goal is scored!
    /// </summary>
    /// <param name="other"></param>
    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "goal") {
            ball.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            score.SetActive(true);
            StartCoroutine(showGoal());

            if(other.gameObject.name == "goal1") {
                gm.GetComponent<gameManager>().scoreA++;

            }
            if (other.gameObject.name == "goal2") {
                gm.GetComponent<gameManager>().scoreB++;
            
            }
        }
    }
    IEnumerator showGoal() {
       // while (enabled) {
        justScored = true;
        yield return new WaitForSeconds(goalTimer);
        ball.transform.position = new Vector3(0, 0, -0.05f);
        score.SetActive(false);
        lockBall = true;
        justScored = false;
    }
}
