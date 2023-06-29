using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformtime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.up * 10 * Time.deltaTime);
    }
}
