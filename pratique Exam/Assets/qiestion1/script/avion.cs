using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avion : MonoBehaviour {

    Rigidbody plane;

       GameObject helice;
    float speed;
	// Use this for initialization
	void Start () {

        plane = gameObject.GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update () {
        if(    Input.GetAxis("Jump") != 0)
        {
            
            plane.AddForce(0, 0, 60000 * Time.deltaTime);

           
        }
        speed = plane.velocity.z;
        helice = GameObject.FindGameObjectWithTag("helice");
         helice.transform.Rotate(Vector3.forward * 45 * Time.deltaTime * speed );
    }
}
