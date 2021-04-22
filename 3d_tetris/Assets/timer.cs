using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text clock;
    private float startTime;
    private bool end = false;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(end)
            return;
        float t = Time.time - startTime;

        string minutes = ((int) t/60).ToString();
        string seconds = (t%60).ToString("f2");

        clock.text = minutes + ":" + seconds;
    }

    public void Finish()
    {
        //clock.color = 
        end = true;
    }

    public float getTime()
    {
        float t = Time.time - startTime;
        return t;
    }
}
