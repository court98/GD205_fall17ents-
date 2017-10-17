using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic3DPlus : MonoBehaviour
{


    public class Basic3D : MonoBehaviour
    {
        public GameObject mover;

        public float moveSpeed;
        public Vector3 startingPosition;


        // Use this for initialization

        void Start()
        
        {
            startingPosition = mover.transform.position;
            moveSpeed = 0.5f;

        }



        // Update is called once per frame

        void Update()
        {
            if (mover.transform.position.z < 0) {
            }

            transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical"));//this code watch a youtube video for//
        }
    }

}
