using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (target != null)
        {
            Vector3 targetPos = target.position + offset;
            Vector3 smoothedPos = Vector3.Lerp(transform.position, targetPos, smoothSpeed);
            transform.position = smoothedPos;

            transform.LookAt(target);
        }
    }
}
