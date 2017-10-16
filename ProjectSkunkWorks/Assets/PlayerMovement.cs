using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    //private Rigidbody rigid;
    private Vector3 direction;
    private Vector3 movement;
    private Transform transPlayer;

    public float speed = 7;

	void Start () {
        //Always get your components to access them...
        //rigid = this.GetComponent<Rigidbody>();
        transPlayer = this.GetComponent<Transform>();
	}
	
	void Update () {
        //This gets the direction that the player will follow
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        //Using a RigidBody to simulate real world walking...
        //movement = new Vector3(direction.x * speed, direction.y * speed, direction.z * speed);
        //rigid.AddForce(movement, ForceMode.Acceleration);

        //Using the Transform.Translate method to move the player...
        transPlayer.Translate(direction.x * speed * Time.deltaTime, 0, direction.z * speed * Time.deltaTime);
	}
}
