using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class rotation_ : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * 10f);
    }

}
