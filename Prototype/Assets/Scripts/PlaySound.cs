using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {
	public AudioSource GunShot;
	// Use this for initialization
	void Start () {
		GunShot = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){

			GunShot.Play ();
		}
	}
}
