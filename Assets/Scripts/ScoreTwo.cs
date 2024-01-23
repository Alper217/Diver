using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTwo : MonoBehaviour
{
    public Text scoreText;
    public static int scoreCount;
    private void Update()
    {
        scoreText.text = $"Score : {scoreCount}";


        if (scoreCount > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", scoreCount);
        }

    }
}
