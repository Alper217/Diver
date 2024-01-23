using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SquidColorCode : MonoBehaviour
{
    [SerializeField] Image image;
    private Color color;
    [SerializeField] float deger = 0.1f;

    void Start()
    {
        if (image != null)
        {
            color = image.color;
        }
        else
        {
            Debug.LogError("Image atanmamýþ!");
        }
    }
    private void OnTriggerStay(Collider other)
    {
       
        if (other.gameObject.tag == "squid")
        {
            Debug.Log("AHTAPOT");
            color.a = 1;
            image.color = color; 
        }
        if (other.gameObject.tag == "Below" || other.gameObject.tag == "Surface")
        {
            Invoke("EkranKararmasi",10f);
        }
    }
    void EkranKararmasi()
    {
        color.a -= deger * Time.deltaTime;
        image.color = color; 
    }
}
