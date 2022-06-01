using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject startButton;
    public GameObject levelText;
    public GameObject levelButton1;
    public GameObject levelButton2;
    public GameObject levelButton3;

    public void LevelSerect()
    {
        startButton.SetActive(false);
        levelText.SetActive(true);
        levelButton1.SetActive(true);
        levelButton2.SetActive(true);
        levelButton3.SetActive(true);
    }

    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }

    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, false);
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
