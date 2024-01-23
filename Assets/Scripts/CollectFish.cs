using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectFish : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    public float score=0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            score += 5;
            Destroy(gameObject);
            text.text = $"Score :{score}";
        }

    }
}
