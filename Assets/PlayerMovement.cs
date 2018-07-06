using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 1;     


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



        //transform.Rotate (new Vector3 (0,0,0) * Time.deltaTime);


        transform.localRotation = Quaternion.identity;



    }


       


    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W))

            transform.Translate(Vector3.forward * speed);


        if (Input.GetKey(KeyCode.S))

            transform.Translate(Vector3.back * speed);



        if (Input.GetKey(KeyCode.D))

            transform.Translate(Vector3.right * speed);


        if (Input.GetKey(KeyCode.A))

            transform.Translate(Vector3.left * speed);




    }
}
