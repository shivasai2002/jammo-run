using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Playercontroller : MonoBehaviour
{
    public Animator _player;
    public TMP_Text _scoreText;
    public TMP_Text _lifeText;

    int score;
    int life;
    //Start is called before the first frame update
    void Start()
    {
        score = 0;
        life = 3;        
        _scoreText.text = "Score :" + score;
        _lifeText.text = "Life :" + life;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            _player.SetInteger("state", 1);
            transform.Translate(Vector3.forward * 2.0f * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.R))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            _player.SetInteger("state", 2);
            transform.Translate(Vector3.forward * 5.0f * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
            _player.SetInteger("state", 2);
            transform.Translate(Vector3.forward * 5.0f * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0,-90, 0);
            _player.SetInteger("state", 2);
            transform.Translate(Vector3.forward * 5.0f * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            _player.SetInteger("state", 2);
             transform.Translate(Vector3.forward * 5.0f * Time.deltaTime);
        }
        
        else
            _player.SetInteger("state", 0);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            life--;
            _lifeText.text = "Life :" + life;

            if (life <= 0)
                Application.LoadLevel(0);
        }
        if (collision.gameObject.tag == "coin")
        {
            Destroy(collision.gameObject);
            score++;
            _scoreText.text = "Score :" + score;
        }
    }
}
