using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighScoreManager : MonoBehaviour
{
    public TextMeshProUGUI HighScoresDisplay
    { get; private set; }

    private void Awake()
    {
        HighScoresDisplay = GameObject.Find("Canvas/HighScoreList").GetComponent<TextMeshProUGUI>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // The text should be updated to any saved data here.
        DisplayHighScores();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DisplayHighScores()
    {
        if (DataManager.Instance != null)
        {
            string scoreTextToDisplay = DataManager.Instance.ConvertTopTenScoresToString();
            HighScoresDisplay.text = scoreTextToDisplay;
        }
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("menu");
    }
}
