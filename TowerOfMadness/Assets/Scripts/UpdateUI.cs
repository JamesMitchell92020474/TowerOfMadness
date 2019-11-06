using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class UpdateUI : Singleton<UpdateUI>
{
    public static bool gameIsPaused = false;

    public GameObject mainUI;
    public GameObject gemPopup;
    public GameObject deathPopup;
    public GameObject endOfLevel;
    public GameObject pauseMenu;
    public GameObject fpsObj;
    //private FirstPersonController fpsScript;

    [SerializeField]
    private Text timerLabel;

    [SerializeField]
    private Text scoreLabel;

    [SerializeField]
    private Text gemsLabel;

    [SerializeField]
    private Text gemPopupLabel;

    // Initialiser
    void Start()
    {
        GameObject fpsObj = GameObject.Find("Player");
       // FirstPersonController fpsScript = fpsObj.GetComponent<FirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        timerLabel.text = FormatTime(GameManager.Instance.TimeRemaining);
        scoreLabel.text = "Score: " + GameManager.Instance.score.ToString();
        gemsLabel.text = "Gems Remaining: " + GameManager.Instance.gemsRemaining.ToString();
        //gemPopupLabel.text = "This is a gem. You must find all of these before you can exit the level.";

        // Pause Menu
        /*if(Input.GetKeyDown("p"))
        {
            //If the game is already paused, resume game
            if(gameIsPaused)
            {
                pauseMenu.SetActive(false);
                Resume();
            } 
            
            // If the game is not paused, pause game
            else {
                pauseMenu.SetActive(true);
                Pause();
            }
        }*/
    }

    private string FormatTime(float timeInSeconds)
    {
        return string.Format("Time: {0}:{1:00}", Mathf.FloorToInt(timeInSeconds / 60), Mathf.FloorToInt(timeInSeconds % 60));
    }

    /*public void Resume()
    {
       Time.timeScale = 1f;
       gameIsPaused = false;
       fpsScript.enabled = true;
    }

    void Pause()
    {
       //Time.timeScale = 0.0f;
       gameIsPaused = true;
       fpsScript.enabled = false;
       if(fpsScript.enabled = false)
       {
           Debug.Log("FPS Script disabled");
       }
       Cursor.lockState = CursorLockMode.None;
       Cursor.visible = true;
    }

    public void LoadMainMenu()
    {

    }

    public void QuitGame()
    {

    }*/
}
