using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] private GameObject inputBox;
    
    [SerializeField] private TMP_Text HighScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        Manager.Instance.LoadHighScore();
        
        HighScoreText.text = "Best Score : " + Manager.Instance.highScoreName + " : " + Manager.Instance.highScoreValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        string nameText = inputBox.GetComponent<TMP_InputField>().text;
        Manager.Instance.nameVal = nameText;
        
        SceneManager.LoadScene(1);
    }
}