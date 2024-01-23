using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonsCode : MonoBehaviour
{
    [SerializeField] Image MainMenu;
    [SerializeField] Button startbutton;
    [SerializeField] Button endbutton;
    [SerializeField] Button InfoButton;
    [SerializeField] Image InfoMenu;
    [SerializeField] Image Wait;
    [SerializeField] Image Restart;
    
  public void Play()
    {
        MainMenu.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Guýde()
    {
        InfoMenu.gameObject.SetActive(true);
    }
    public void GuideExit()
    {
        InfoMenu.gameObject.SetActive(false);
    }
    public void WaitExit()
    {
        Wait.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Exit()
    {
        Application.Quit();
    }
    public  void RestartTime()
    {
        SceneManager.LoadScene(0);
        Score.scoreCount = 0;
    }
}
