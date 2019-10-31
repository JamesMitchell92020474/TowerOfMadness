using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateUI : MonoBehaviour
{
    [SerializeField]
    private Text timerLabel;

    [SerializeField]
    private Text scoreLabel;

    [SerializeField]
    private Text gemsLabel;

    [SerializeField]
    private Text gemPopup;

    // Start is called before the first frame update
    void Start()
    {
        gemPopup.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timerLabel.text = FormatTime(GameManager.Instance.TimeRemaining);
        scoreLabel.text = "Score: " + GameManager.Instance.score.ToString();
        gemsLabel.text = "Gems Remaining: " + GameManager.Instance.gemsRemaining.ToString();
        gemPopup.text = "This is a gem. You must find all of these before you can exit the level.";
    }

    private string FormatTime(float timeInSeconds)
    {
        return string.Format("Time: {0}:{1:00}", Mathf.FloorToInt(timeInSeconds / 60), Mathf.FloorToInt(timeInSeconds % 60));
    }
}
