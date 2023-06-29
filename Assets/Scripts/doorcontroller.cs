using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorcontroller : MonoBehaviour
{
    public static bool _isopen;
    // Start is called before the first frame update
    void Start()
    {
        _isopen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (_isopen == true && transform.position.y>=-5.0f) 
        transform.Translate(Vector3.down * 0.01f);
    }
}
