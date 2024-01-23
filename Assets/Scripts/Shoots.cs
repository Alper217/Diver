using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Shoots : MonoBehaviour
{
    public TextMeshProUGUI text;
    float score = 0;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fish1"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Score.scoreCount += 3;
        }
        if (other.CompareTag("Fish2"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Score.scoreCount += 6;
        }
        if (other.CompareTag("Fish3"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Score.scoreCount += 8;
        }
        if (other.CompareTag("Fish4"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Score.scoreCount += 20;
        }

    }
}
