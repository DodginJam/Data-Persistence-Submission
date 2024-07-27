using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuManager : MonoBehaviour
{
    public TMP_InputField UserNameInputField
    { get; private set; }

    private void Awake()
    {
        UserNameInputField = GetComponentInChildren<TMP_InputField>();
    }

    // Start is called before the first frame update
    void Start()
    {
        UserNameInputField.onEndEdit.AddListener(value => SetUserName(value));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartMainGame()
    {
        SceneManager.LoadScene("main");
    }

    public void LoadHighScores()
    {
        SceneManager.LoadScene("highScoresDisplay");
    }

    public void ExitApplication()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#elif UNITY_WEBGL
        Application.OpenURL("about:blank");
#else
        Application.Quit();
#endif
    }

    public void SetUserName(string name)
    {
        if (DataManager.Instance != null)
        {
            DataManager.Instance.UserName = name;
        }
    }
}
