using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shrink : MonoBehaviour {

    Vector3 scale;
    Vector3 minSize;
    int count;
	// Use this for initialization
	void Start () {
        minSize = new Vector3(0.2f, 0.2f, 0.2f);
        count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D other) {
        count++;
        updateSize();
        if(count == 4) {
            Destroy(this.gameObject);
        } else { 
            scale.Set(scale.x * 0.8f, scale.y * 0.8f, scale.z * 0.8f);
            this.transform.localScale = scale;
        }
    }

    void updateSize() {
        //size = new Vector3(this.transform.localScale.x, this.transform.localScale.y, this.transform.localScale.z);
        scale = this.transform.localScale;
    }
}
