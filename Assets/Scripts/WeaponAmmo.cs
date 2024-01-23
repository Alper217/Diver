using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAmmo : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bullet;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Ateþ");
            Shoot();
        }   
    }
    void Shoot()
    {
        Instantiate(bullet,FirePoint.position,FirePoint.rotation);
    }
}
