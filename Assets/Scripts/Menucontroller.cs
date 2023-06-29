using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menucontroller : MonoBehaviour
{
    public GameObject _MenuPanel;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    public void Onbuttonclick(GameObject _object)
    {
        if (_object.gameObject.name == "Start")
        {
            _MenuPanel.SetActive(false);
            Time.timeScale = 1;
        }
            
        if (_object.gameObject.name == "Exit")
            Application.Quit();
    }
    
}
