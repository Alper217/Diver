using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordTime : MonoBehaviour
{
    public static float LastTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (LastTime > PlayerPrefs.GetInt("Record Time"))
        {
            PlayerPrefs.SetFloat("Record Time", LastTime);
        }
    }
}
