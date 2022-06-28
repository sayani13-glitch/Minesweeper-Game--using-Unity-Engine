using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timerscript : MonoBehaviour
{
    public static float ct=0f;
    public static int f;
    public Text timer;
    float st;
    void Start()
    {
        if(level.t!=60 && level.t!=30)
        {
            st = 90;
        }
        else
        {
            st = level.t;
        }
        f = -1;
        ct = st;
        Debug.Log(ct);
    }

  
    void Update()
    {
        Debug.Log(ct);
        if(f!=-1)
        {
            if (f == 1)
            {
                f = 0;
                ct = st + 1;
            }
            if (f==0 && ct>0)
            {
                ct -= Time.deltaTime;
                timer.text = "" + (int)ct;
            }
            if(ct<1)
            {
                Invoke("gameover", 2);
            }
            
        }
     
    }
    public void gameover()
    {
        SceneManager.LoadScene("gameover");
    }

}
