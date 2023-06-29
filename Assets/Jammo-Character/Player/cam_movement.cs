using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam_movement : MonoBehaviour
{
    public Transform targetObject;
    public bool lookAtTarget = false;

    public Vector3 cameraOffset;

    //Smoothing factor which we will use for the Camera rotation
    public float smoothFactor = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - targetObject.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPosition = targetObject.transform.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPosition, smoothFactor);
        if (lookAtTarget)
        {
            transform.LookAt(targetObject);
        }
        float mouseXvalue = Input.GetAxis("Mouse X");
        // float mouseYvalue = Input.GetAxis ("Mouse Y");  

        if (mouseXvalue != 0)
        {
            transform.Rotate(Vector3.up * 5 * mouseXvalue);
        }
    }
}