using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falldetect : MonoBehaviour {
    Vector3 checkpoint;
	// Use this for initialization
	void Start () {
        checkpoint = new Vector3(-6, 0, 1);
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < -10)
        { transform.position=checkpoint;

        }
	}
}
