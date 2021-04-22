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
    double s = 0;
    private int frames = 0;


    timer timer = new timer();
    GameManager gm = new GameManager();


    // Start is called before the first frame update
    void Start()
    {
        startScore = 0;
        score.text = startScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(end)
            return;

        int blocks = gm.getBlockCounter();
        double b = (double)blocks;
        
        double time = (double)timer.getTime();

        print("time: " + time);
        print("block count: " + b);

        b = b*40000;

        double capacity = b/totalCapacity;
        double s =+ (capacity*100)/time;

        frames++; 
        if(frames% 100 == 0){
            score.text = s.ToString("f0");
        }
    }
}
