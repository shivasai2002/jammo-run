using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator _playerAnimator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            //_playerAnimator.SetInteger("state", 0);
            //transform.rotation = Quaternion.Euler(0, 4, 0);
            transform.Translate(Vector3.right * 10 * Time.deltaTime);
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            //_playerAnimator.SetInteger("state", 1);
            transform.Translate(Vector3.left * 10 * Time.deltaTime);
            //transform.rotation = Quaternion.Euler(0, -4, 0);
        }
        else if (Input.GetKey(KeyCode.R))
        {
            //_playerAnimator.SetInteger("state", 2);
            transform.Translate(Vector3.left * 5 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        //_playerAnimator.SetInteger("state", 0);
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coin")
            Destroy(collision.gameObject);
        if (collision.gameObject.tag == "Enemy")
            Application.LoadLevel(0);
    }
}
