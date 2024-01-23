using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpOrDown : MonoBehaviour
{
    [SerializeField] GameObject Character;
    void Start()
    {
        Character.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GoUpOrDown();
        Character.transform.position = transform.position;
    }
    void GoUpOrDown()
    {
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up*Time.deltaTime*5);
            //transform.rotation = Quaternion.Euler(0, 0, 45);
        }
        if (Input.GetKey(KeyCode.DownArrow)|| Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down*Time.deltaTime*2);
            //transform.rotation = Quaternion.Euler(0, 0, -45);
        }
    }
}
