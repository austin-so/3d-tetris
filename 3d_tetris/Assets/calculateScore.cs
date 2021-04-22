using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class calculateScore : MonoBehaviour
{
    public Text score;
    private float startScore;
    private bool end = false;
    private double totalCapacity = 10*10*40;


    timer timer = new timer();

    // Start is called before the first frame update
    void Start()
    {
        startScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(end)
            return;

        //int blocks = getBlocks();
        double time = (double)timer.getTime();

        //temp test value
        double blocks = 57;

        double capacity = blocks/totalCapacity;
        double s =+ (capacity*100)/time;



        score.text = s.ToString("f0");
    }
}
