using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    bool pugWin = false;
    bool frogWin = false;
    float delay = 3f;

    public void EndGame()
    {
        if (pugWin == false)
        {
            pugWin = true;
            Debug.Log("Pug win");
            Invoke("PugVictory", delay);
        } 

        if (frogWin == false)
        {
            frogWin = true;
            Debug.Log("Frog win");
            Invoke("FrogVictory", delay);
        }
    }

    void FrogVictory()
    {
        SceneManager.LoadScene(4);
    }

    void PugVictory()
    {
        SceneManager.LoadScene(5);
    }



}
