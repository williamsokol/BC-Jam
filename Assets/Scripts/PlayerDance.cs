using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDance : MonoBehaviour
{
    public Sprite[] mySprite;
    public SpriteRenderer sprite;
    
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
        //print("test");
    }

    // Update is called once per frame
    void Update()
    {
        CheckDanceInput();
    }
    void FixedUpdate()
    {
        if(BadDancing())
        {
            Hp.instance.playerHp -= .01f;
        }
    }

    void CheckDanceInput()
    {
        if (Input.GetButtonDown("Dance1"))
        { 
            //print("Dance1");
            sprite.sprite = mySprite[1];
            // start dance3
        }else if(Input.GetButtonUp("Dance1"))
        { 
            sprite.sprite = mySprite[0];
        }

        if (Input.GetButtonDown("Dance2"))
        { 
            print(Hp.instance.playerHp);
            sprite.sprite = mySprite[2];
            
            // start dance3
        }else if(Input.GetButtonUp("Dance2"))
        { 
            sprite.sprite = mySprite[0];
        }

        if (Input.GetButtonDown("Dance3"))
        { 
            //print("Dance3");
            sprite.sprite = mySprite[3];
            // start dance3
        }else if(Input.GetButtonUp("Dance3"))
        { 
            sprite.sprite = mySprite[0];
        }
    }

    public bool BadDancing()
    {
        if(sprite.sprite == mySprite[2])
        {
            return(true);
        }else
        {
            return(false);
        }
    }
}
