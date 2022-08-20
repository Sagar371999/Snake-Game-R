using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour
{
    public Button startButton;
    public Button exitButton;
    
    private void OnEnable()
    {
        startButton.onClick.AddListener(OnStartClick);
        exitButton?.onClick.AddListener(ExitButtonClick);
    }
    private void OnDisable()
    {
        startButton.onClick.RemoveListener(OnStartClick);
        exitButton?.onClick.RemoveListener(ExitButtonClick);
    }
    private void OnStartClick()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
        //SceneManager.UnloadSceneAsync(1);
        
    }

    private void ExitButtonClick()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif

    }
}
