using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinspawning : MonoBehaviour
   
{
    public GameObject _coinPrefab;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(_coinPrefab);
        //Instantiate(_coinPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        for (int i = 0; i < 5; i++)
            Instantiate(_coinPrefab, new Vector3(i * -2.0f, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
