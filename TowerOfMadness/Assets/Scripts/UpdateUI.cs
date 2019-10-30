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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerLabel.text = FormatTime(GameManager.Instance.TimeRemaining);
        scoreLabel.text = "Score: " + GameManager.Instance.score.ToString();
        gemsLabel.text = "Gems Remaining: " + GameManager.Instance.gemsRemaining.ToString();
    }

    private string FormatTime(float timeInSeconds)
    {
        return string.Format("Time: {0}:{1:00}", Mathf.FloorToInt(timeInSeconds / 60), Mathf.FloorToInt(timeInSeconds % 60));
    }
}
