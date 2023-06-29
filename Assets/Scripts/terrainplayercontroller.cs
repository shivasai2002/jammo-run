using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terrainplayercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0,1,0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -1, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
           transform.Translate(Vector3.forward * 5.0f * Time.deltaTime);
        }


    }
}
