using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level : MonoBehaviour
{
    
    public static double l;
    public static float t;
    public Button play;
    public Button go;
    public Image logo;
    void Start()
    {
        go.gameObject.SetActive(false);

      
    }
    
    public void playbuttonclick()
    {
        logo.gameObject.SetActive(false);
        play.gameObject.SetActive(false);
        go.gameObject.SetActive(true);
    }
    public void gobuttonclick()
    {
        SceneManager.LoadScene("game");
        
    }
    public void dropclick(int val)
    {
        if(val==0)
        {
            l = 0.15;
            t = 90;
        }
        if(val==1)
        {
            l = 0.3;
            t = 60;
        }
        if(val==2)
        {
            l = 0.5;
            t = 30;
        }
        Debug.Log(l);
        Debug.Log(t);
    }

   
}
