using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    [SerializeField] private Image _time;
    [SerializeField] private TextMeshProUGUI _timeText;
    private float _currentTime;
    [SerializeField] private float _maxDuration; // Use a maximum duration for the countdown

    void Start()
    {
        _currentTime = 0f; // Start from zero
        _timeText.text = _currentTime.ToString();
        StartCoroutine(CountdownTime());
    }

    private IEnumerator CountdownTime()
    {
        while (true) // Run indefinitely until the game is closed
        {
            _time.fillAmount = Mathf.InverseLerp(0, _maxDuration, _currentTime);
            _timeText.text = _currentTime.ToString();
            yield return new WaitForSeconds(1f);
            _currentTime++;

        }
    }
}
