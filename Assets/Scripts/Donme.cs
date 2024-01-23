using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dönme : MonoBehaviour
{
    public float donmeHizi = 100f;
    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            Don(donmeHizi);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            Don(-donmeHizi);
        }
    }
    void Don(float hiz)
    {
       
        // Transform.Rotate ile yuvarlağın kendi ekseni etrafında dönmesini sağla
        transform.Rotate(Vector3.forward, hiz * Time.deltaTime);
    }
}
