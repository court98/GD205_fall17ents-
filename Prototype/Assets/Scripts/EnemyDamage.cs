﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {
	
	int EnemyHealth =100;
	int TheDamage = 10;

	public void ouchthathurt()
	{   EnemyHealth -= TheDamage;
		print("ouchthathurtYo"+EnemyHealth);
		TheEnemyisDead();
	}

	void OnCollisionEnter(Collision GhostHit){
		if (GhostHit.gameObject.tag == "Bullet") {
			ouchthathurt ();

		}
	}
	void TheEnemyisDead(){

		Destroy(gameObject);

	}

}

