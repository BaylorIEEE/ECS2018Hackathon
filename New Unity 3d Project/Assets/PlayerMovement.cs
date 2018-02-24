//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000;
    public float sidewaysForce = 500;

	// Use this for initialization
	void Start () {
        Debug.Log("Hello world!");
        rb.useGravity = true;
        rb.AddForce(0, 2, 5);
        //for(int i=0; i<9999; i++) { rb.useGravity = true; }
	}
	
	// Update is called once per frame
	void FixedUpdate () {                           //normally just Update, but FixedUpdate is smoother on unity
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);  //adding this time part will make sure it looks the same across dif speed comps
        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }   
}
