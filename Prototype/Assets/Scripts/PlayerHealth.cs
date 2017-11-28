using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
	public float MaxHealth = 100f;
	public float currentHealth = 0f;
	public GameObject HealthBar;

	// Use this for initialization
	void Start () {
		currentHealth = MaxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void DecreaseHealth(){

		currentHealth -= 5f;
		float calcHealth = currentHealth / MaxHealth;

	}

	public void SetHealthBar(float myHealth){
	
	
		HealthBar.transform.localScale = new Vector3 (myHealth, HealthBar.transform.localScale.y, HealthBar.transform.localScale.z);
	
	}
}
