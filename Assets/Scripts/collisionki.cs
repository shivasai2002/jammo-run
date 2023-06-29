using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class collisionki : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI _lifetext;
    public TextMeshProUGUI _scoretext;
    public int score;
    public int life;
    void Start()
    {
        life = 5;
        score = 0;
        _scoretext.text = "Score:" + score;
        _lifetext.text = "Life:" + life;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.up * 10*Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.down * 10f*Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * 10*Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * 10*Time.deltaTime);
    }
    public void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("It's Collided");
        if (collision.gameObject.tag == "enemy")
        {
            //Destroy(this.gameObject);
            life--;
            _lifetext.text = "Life:" + life;
        }
            
        if (collision.gameObject.tag == "coin")
        {
            Destroy(collision.gameObject);
            score++;
            _scoretext.text = "Score:" + score;
        }
            
    }
}
