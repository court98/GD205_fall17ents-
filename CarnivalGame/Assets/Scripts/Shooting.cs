using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
	public GameObject thebullet;
	public Transform barrelEnd;
	public int bulletSpeed;
	public float despawnTime = 3.0f;
	public bool shootAble = true;
	public float WaitForNextShot = 0.25f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Mouse0))
		{
			if (shootAble) 
			{
				shootAble = false;
				Shoot();
			} 
		}
	}
	IEnumerator ShootingYield() {
		yield return new WaitForSeconds (WaitForNextShot); 
		shootAble = true;
	
	
	}



	void Shoot()
	{
		var bullet = Instantiate (thebullet, barrelEnd.position, barrelEnd.rotation);
		bullet.GetComponent<Rigidbody> ().velocity = bullet.transform.forward * bulletSpeed;

		Destroy (bullet, despawnTime);
	}
}
