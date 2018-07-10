using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 1;
    public GameObject bulletPrefab;
    public Transform bulletSpawn; 



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



        //transform.Rotate (new Vector3 (0,0,0) * Time.deltaTime);


        transform.localRotation = Quaternion.identity;


        if (Input.GetKey(KeyCode.Space))

            Fire(); 



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

       // if (Input.GetKeyDown(KeyCode.G))

         //   transform.Translate(new Vector3(0,0,5));
            



    }


    void Fire()

    {
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position, 
            bulletSpawn.rotation
            );

        //add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 20;

        //destroy bullet after X seconds

        Destroy(bullet, 1.0f);
        


    }


}
