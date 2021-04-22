using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject iPrefab;
    public GameObject tPrefab;
    public GameObject zPrefab;
    public GameObject sPrefab;
    public int blockCounter;
    float tempPos;
    int count; // want to check Update once every 30 frames

    GameObject block;
    // Start is called before the first frame update
    void Start()
    {
        blockCounter = 0;
        tempPos = -1;
        count = 0;
        //InvokeRepeating("DropBlock", 0, 5.0f);
        DropBlock();
    }

    void DropBlock()
    {
        // Randomly generate block
        int randGen = Random.Range(1, 5);
        switch (randGen)
        {
            case 1:
                block = Instantiate(iPrefab, new Vector3(0, 40.0f, 12), Quaternion.identity);
                break;
            case 2:
                block = Instantiate(tPrefab, new Vector3(0, 40.0f, 12), Quaternion.identity);
                break;
            case 3:
                block = Instantiate(zPrefab, new Vector3(0, 40.0f, 12), Quaternion.identity);
                break;
            case 4:
                block = Instantiate(sPrefab, new Vector3(0, 40.0f, 12), Quaternion.identity);
                break;
        }

        // Spawn block
        block.transform.position = new Vector3(0, 40.0f, 12);
        blockCounter++;
    }

    public int getBlockCounter()
    {
        return blockCounter;
    }

    // Update is called once per frame
    void Update()
    {
        // Checks state of game once every second
        // Will only spawn if the previous block isn't moving anymore
        count++;
        if(count >= 30) {
            count = 0;
            if(block.transform.position.y == tempPos)
            {
                DropBlock();
            }
            else
            {
                tempPos = block.transform.position.y;
                Debug.Log("Temp: " + tempPos + "\nBlock: " + block.transform.position.y);
            }
        }

    }
}