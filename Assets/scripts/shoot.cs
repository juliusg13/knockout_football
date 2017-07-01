using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

    GameObject ball;
    public float thrust;
    public Rigidbody2D rb;
    Vector2 vel, target;
    float magnitude, step;
    // Use this for initialization
    void Start() {
        ball = GameObject.FindGameObjectWithTag("ball");
        rb = GetComponent<Rigidbody2D>();
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
        /*if (magnitude < 1) {
            ball.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }*/
    }

    void Shoot() {
        if (Input.GetMouseButtonDown(0)) {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //            target = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            //            Vector2 origin = Camera.main.WorldToViewportPoint(ball.transform.position);
            Vector2 origin = ball.transform.position;

            rb.velocity = (2 * (target - origin));




            //ball.GetComponent<Rigidbody2D>().AddForce(target - origin, ForceMode2D.Force);
            //Debug.Log("origin: " + origin);
            //Debug.Log("destination: " + target);
            //    bullet.SendMessage ("gotot");
        }
    }
    void FixedUpdate() {

    }
    Vector2 evalLocation(Vector2 origin, Vector2 destination) {
        Vector2 ret;
        /*if(origin.x >= destination.x && origin.y >= destination.y) {
            ret = new Vector2(origin.x - destination.x, origin.y - destination.y);
        } else if(origin.x >= destination.x && origin.y < destination.y) {
            ret = new Vector2(origin.x )
        } else if(origin.x < destination.x && origin.y > destination.y) {

        } else { //both origin points are smaller OR equal to destination, so they will cancel each other out if same size.

        }*/
        ret = new Vector2(origin.x - destination.x, origin.y - destination.y);

        return ret;
    }
}
