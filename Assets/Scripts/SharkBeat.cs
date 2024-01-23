using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class SharkBeat : MonoBehaviour
{
    [SerializeField] Image LoadScreen;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Shark")
        {
            Debug.Log("Köpke");
            Time.timeScale = 0f;
            LoadScreen.gameObject.SetActive(true);
            
        }
    }
}
