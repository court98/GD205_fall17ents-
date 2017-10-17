using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Vector3 checkpoint;
    public Transform player;
    private GameObject bomb;

    // Use this for initialization
    void Start()
    {
        player.transform.position= new Vector3(7, 1, -7);
        checkpoint = new Vector3(-7, 1, -8);
    }   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag==("Bomb"))
        {
            player.transform.position = checkpoint;

        }
    }
    // Update is called once per frame
    void Update()
    {


    }
}