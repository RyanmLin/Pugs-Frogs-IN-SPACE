using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class StartGameButton : MonoBehaviour
{

    public string mainMenuScene;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loadMenu()
    {
        SceneManager.LoadScene(mainMenuScene);
    }
}