using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private float _timeRemaining;

    public float TimeRemaining 
    {
        get { return _timeRemaining; }
        set { _timeRemaining = value; }
    }

    private float maxTime = 5 * 60; // in seconds

    public int numDiamonds;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        TimeRemaining = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        TimeRemaining -= Time.deltaTime;

        if (TimeRemaining <= 0)
        {
            // Do Something for when the time runs out
        }
    }
}
