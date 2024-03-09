using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HighScoreData
{
    public string highScoreName;
    public int highScoreValue;
    
    // The values defined in this constructor will be the default values
    // The game starts with when there's no data to load
    public HighScoreData()
    {
        this.highScoreName = "";
        this.highScoreValue = 0;
    }
}