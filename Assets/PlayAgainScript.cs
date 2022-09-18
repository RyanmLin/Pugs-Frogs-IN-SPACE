using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PlayAgainScript : MonoBehaviour
{
    public string fightArenaScene;
    public string mainMenuScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(fightArenaScene);
    }
    public void loadMenu()
    {
        SceneManager.LoadScene(mainMenuScene);
    }
}
