using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameoverscript : MonoBehaviour
{
    public Image win;
    public Image loss;
    
    public void onclickrestart()
    {
        
        SceneManager.LoadScene("game");
        Playfield.totalcount = 0;
    }
    public void onclicknewgame()
    {
        
        SceneManager.LoadScene("intro");
    }
    public void onclickexit()
    {
        
        Application.Quit();
    }
    void Start()
    {
        
        if (Element.win == 1)
        {
            loss.gameObject.SetActive(false);
            win.gameObject.SetActive(true);
            Debug.Log("you win");
        }
        else
        {
            win.gameObject.SetActive(false);
            loss.gameObject.SetActive(true);
            Debug.Log("you lose");
        }
    }
}
