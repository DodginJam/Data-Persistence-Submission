using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField UserNameInput
    { get; private set; }

    private void Awake()
    {
        UserNameInput = GetComponentInChildren<TMP_InputField>();
    }

    // Start is called before the first frame update
    void Start()
    {
        UserNameInput.onEndEdit.AddListener(value => SetUserName(value));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartMainGame()
    {
        SceneManager.LoadScene("main");
    }

    public void SetUserName(string name)
    {
        if (DataManager.Instance != null)
        {
            DataManager.Instance.UserName = name;
        }
    }
}
