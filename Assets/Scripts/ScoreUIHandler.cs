using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreUIHandler : MonoBehaviour
{
    [SerializeField] private GameObject highscoreCanvas;
    private Manager manager;
    
    private void Start()
    {
        manager = GameObject.Find("Manager").GetComponent<Manager>();
        
        DisplayHighScores();
    }
    
    // Loop through the high scores from highScoreDatas and display them
    public void DisplayHighScores()
    {
        // Get the high score list
        List<HighScoreData> highScoreDatas = manager.highScoreDatas;
        
        // Loop through the high scores and display them by highest score first
        highScoreDatas.Sort((x, y) => y.highScoreValue.CompareTo(x.highScoreValue));

        int numberOfPositions = 5;

        if (highScoreDatas.Count < 5)
        {
            numberOfPositions = highScoreDatas.Count;
        }
 
        for (int i = 0; i < numberOfPositions; i++)
        {
            highscoreCanvas.transform.GetChild(i).Find("Position").GetComponent<TMPro.TextMeshProUGUI>().text = (i + 1).ToString();
            highscoreCanvas.transform.GetChild(i).Find("PlayerName").GetComponent<TMPro.TextMeshProUGUI>().text = highScoreDatas[i].highScoreName;
            highscoreCanvas.transform.GetChild(i).Find("Score").GetComponent<TMPro.TextMeshProUGUI>().text = highScoreDatas[i].highScoreValue.ToString();
        }
    }
}
