using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
    [SerializeField] TMP_Text scoreDisplay;
    [SerializeField] TMP_Text HighDisplayText;
    //[SerializeField] Text TimeDisplayText;

    void Start()
    {

            HighScoreDisplay();
            //TimeDisplay();
 
    }

    private void HighScoreDisplay()
    {
        HighDisplayText.text = "High Score : " + PlayerPrefs.GetInt("HighScore");
    }
    //private void TimeDisplay()
    //{
    //    TimeDisplayText.text = "Record Time : " + PlayerPrefs.GetInt("Time");
    //}
    
}
