using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    private Camera mainCamera;
    private Transform player;

    public Vector3 offset;

	// Use this for initialization
	void Start () {
        mainCamera = this.GetComponent<Camera>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();		
	}
	
	// Update is called once per frame
	void Update () {
        mainCamera.GetComponent<Transform>().position = player.position + offset;
	}
}
