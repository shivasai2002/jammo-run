using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class inputcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    //public TMP_Text _scoreText;
    //public TMP_Text _lifeText;
    
    //int score;
    //int life;

    void Start()
    {
        //score = 0;
        //life = 3;        
        //_scoreText.text = "Score :" + score;
        //_lifeText.text = "Life :" + life;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
       
        if (Input.GetKey(KeyCode.D) && screenPos.x < (Screen.width-100.0f))
            transform.Translate(Vector3.right * 0.1f);
        if(Input.GetKey(KeyCode.A) && screenPos.x > (0.0f + 100.0f))
            transform.Translate(Vector3.left * 0.1f);

        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.up * 0.01f);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.down * 0.01f);

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null)
                {
                    Debug.Log(hit.transform.name);
                    transform.GetComponent<Rigidbody>().AddForce(transform.forward * 50.0f);
                    //transform.GetComponent<Rigidbody>().AddForce(0, 0, 1.0f, ForceMode.Impulse);
                }
            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.tag == "Enemy")
        //{
        //    life--;
        //    _lifeText.text = "Life :" + life;
        //    //Destroy(this.gameObject);
        //}
        //if (collision.gameObject.tag == "Coin")
        //{
        //    Destroy(collision.gameObject);
        //    score++;
        //    _scoreText.text = "Score :" + score;
        //}
    }
}
