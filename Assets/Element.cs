using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Element : MonoBehaviour
{
    public bool mine;
    public Sprite[] emptyTextures;
    public Sprite mineTexture;
    public Text scoretxt;
    double p;
    public static float ct;
    public static int win;
    void Start()
    {
        if(level.l!=0.3 && level.l!=0.5)
        {
            p = 0.15;
        }
        else
        {
            p = level.l;
        }
        Debug.Log(p);
        mine = Random.value < p;
        int x = (int)transform.position.x;
        int y = (int)transform.position.y;
        Playfield.elements[x, y] = this;
        win = -1;
        
    }
    void Update()
    {
        if (timerscript.ct==0)
            gameover();
    }
     public void loadTexture(int adjacentCount)
    {
        if (mine)
            GetComponent<SpriteRenderer>().sprite = mineTexture;
        else
            GetComponent<SpriteRenderer>().sprite = emptyTextures[adjacentCount];
    }
    public bool isCovered()
    {
        return GetComponent<SpriteRenderer>().sprite.texture.name == "default";
    }

    void OnMouseUpAsButton()
    {

      
        if (mine)
        {
            timerscript.f = -1;
            Playfield.uncoverMines();
            win = 0;
            Invoke("gameover", 2);

        }
        
        else
        {
            timerscript.f = 1;
            int x = (int)transform.position.x;
            int y = (int)transform.position.y;
            loadTexture(Playfield.adjacentMines(x, y));   
            Playfield.FFuncover(x, y, new bool[Playfield.w, Playfield.h]);
            int score = Playfield.showscore();
           
            scoretxt.text = " " + score;
            if (Playfield.isFinished())
            {
                win = 1;
                Invoke("gameover", 1);
            }
        }
    }


    public void gameover()
    {
       
        SceneManager.LoadScene("gameover");
    }
   

}
