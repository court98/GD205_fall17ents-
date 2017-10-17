using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSpot : MonoBehaviour {
    public Vector3 winSpot;
    public Vector3 player;

	// Use this for initialization
	void Start () {
        winSpot = new Vector3(1, 0, -2);
        player = new Vector3(7, 0, -1);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag==("winSpot"))
        {
            
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
