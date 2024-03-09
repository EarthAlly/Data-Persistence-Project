using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour, IDataPersistence
{
    public List<HighScoreData> highScoreDatas;
    
    public void LoadData(GameData data)
    {
        highScoreDatas = data.highScoreDatas;
    }

    public void SaveData(GameData data)
    {
        data.highScoreDatas = highScoreDatas;
    }
    
    // Get the highest score from list items of HighScoreData class
    public int GetHighScore()
    {
        int highestScore = 0;
        
        foreach (var highScoreData in highScoreDatas)
        {
            if (highScoreData.highScoreValue > highestScore)
            {
                highestScore = highScoreData.highScoreValue;
            }
        }

        return highestScore;
    }
    
    public string GetHighScoreName()
    {
        int highestScore = 0;
        string highestScoreName = "";
        
        foreach (var highScoreData in highScoreDatas)
        {
            if (highScoreData.highScoreValue > highestScore)
            {
                highestScoreName = highScoreData.highScoreName;
            }
        }

        return highestScoreName;
    }
    
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
