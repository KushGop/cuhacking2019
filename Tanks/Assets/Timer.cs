using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public Text timerText;
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = startTime - Time.time;

        string minutes = (10 + ((int)t / 60)).ToString();
        string seconds = (60+((int)t % 60)).ToString();
        if ((60 + ((int)t % 60)) <= 9)
        {
            seconds = "0" + (60 + ((int)t % 60)).ToString();
        }

        timerText.text = minutes + ":" + seconds;
    }
}
