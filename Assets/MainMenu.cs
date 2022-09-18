using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    public string gameScene;
    public string settingsScene;

    private float delayDuration = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        StartCoroutine(StartGameDelay(delayDuration));   
    }

    public void settings()
    {
        StartCoroutine(SettingsDelay(delayDuration));
    }

    public void exitGame()
    {
        StartCoroutine(ExitDelay(delayDuration));
    }

    private IEnumerator StartGameDelay(float duration)
    {
        yield return new WaitForSeconds(duration);
        SceneManager.LoadScene(gameScene);
    }

    private IEnumerator SettingsDelay(float duration)
    {
        yield return new WaitForSeconds(duration);
        SceneManager.LoadScene(settingsScene);
    }
    private IEnumerator ExitDelay(float duration)
    {
        yield return new WaitForSeconds(duration);
        Application.Quit();
    }
}
