using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damageplayer : MonoBehaviour {
	public int PlayerHealth = 100;
	int damage = 10;

	void Start(){
		print (PlayerHealth);
}


	void OnCollisionEnter(Collision _collision){
		print (PlayerHealth);

		if(_collision.gameObject.tag == "Enemy"){
			PlayerHealth -= damage;
			print ("enemyTouchedMe"+PlayerHealth);

			if(PlayerHealth <= 0){
				gameOver ();
				Destroy (gameObject);

			}



		}
	}
	void gameOver(){
		SceneManager.LoadScene ("GameOver");
	}
}