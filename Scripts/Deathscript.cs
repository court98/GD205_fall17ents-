using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathscript : MonoBehaviour {

    private GameObject bomb;
    public Vector3 Checkpoint;
    public Transform Player;

	// Use this for initialization
	void Start () {
        Checkpoint = new Vector3(-7, 0, -8);
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag== ("Player")) 

        {
            Player.transform.position = Checkpoint=new Vector3(-7, 1, -8);
        }
   

    }
    // Update is called once per frame
    void Update () {
		
	}
}
