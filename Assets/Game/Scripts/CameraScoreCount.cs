using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraScoreCount : MonoBehaviour
{
    private Text scoreCount;
    private int score;



    public int ScoreCounting()
    {
        score++;
        return score;
    }
    void Start()
    {
        scoreCount = GameObject.Find("Score").GetComponent<Text>();
    }

  
    void Update()
    {
        scoreCount.text = score.ToString();
    }
}
