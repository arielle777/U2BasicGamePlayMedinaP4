using JetBrains.Annotations;
using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int lives = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddLives(int value)
    {
        lives += value;
        if (lives <= 0)
        {
            Debug.Log("GameOver");
            lives = 0;
        }
        Debug.Log("Lives = " + lives);
    }
        public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score = " + score);
       
    }
}
