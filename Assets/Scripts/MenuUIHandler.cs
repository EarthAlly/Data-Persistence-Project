using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public Manager manager;

    public PersistentObject persistentObject;
    
    [SerializeField] private GameObject inputBox;
    
    [SerializeField] private TMP_Text HighScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        persistentObject = GameObject.Find("PersistentObject").GetComponent<PersistentObject>();
        manager = GameObject.Find("Manager").GetComponent<Manager>();
        HighScoreText.text = "Best Score : " + manager.GetHighScoreName() + " : " + manager.GetHighScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        string nameText = inputBox.GetComponent<TMP_InputField>().text;
        persistentObject.nameVal = nameText;
        
        DataPersistenceManager.instance.SaveGame();
        
        SceneManager.LoadScene(1);
    }

    public void HighScoreMenu()
    {
        SceneManager.LoadScene(2);
    }
    
    public void SettingsMenu()
    {
        SceneManager.LoadScene(3);
    }
    
    public void Exit()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit(); // Original code to quit Unity player
        #endif
    }
}