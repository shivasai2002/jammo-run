using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //public float speed = 1.0f;
    public Transform target;
    //public Vector3 pos1;
    //public Vector3 pos2;
    void Start()
    {
        //Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        //Debug.Log("Screen Pos " + screenPos);
    }

    // Update is called once per frame
    void Update()
    {
       
        //transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * 2, 3), transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position,target.position, 1 * Time.deltaTime);
        //if (Vector3.Distance(transform.position, target) < 0.001f)
        //{
        //    target *= -1.0f;
        //}

        //transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * 0.5f, 1.0f));



    }
}
