using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ontrigger_ : MonoBehaviour
{
    public TextMeshProUGUI _lifetext;
    public TextMeshProUGUI _scoretext;
    public int score;
    public int life;
    public GameObject _effect;
    // Start is called before the first frame update
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
            transform.Translate(Vector3.up * 10 * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.down * 10f * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * 10 * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * 10 * Time.deltaTime);
    }
    public void OnTriggerEnter(Collider other)
    {
         
        if (other.gameObject.name == "Door")
            doorcontroller._isopen = true;
        //Destroy(other.gameObject);
        // Debug.Log("It's Triggered");
        if (other.gameObject.tag == "coin")
            Instantiate(_effect, new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z), Quaternion.identity);
            Destroy(other.gameObject);
        
    }
}
