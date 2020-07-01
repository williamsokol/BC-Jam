using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDance : MonoBehaviour
{
    public Sprite[] mySprite;
    public SpriteRenderer sprite;
    static public int DanceState;
    static public int DanceGoal;

    public GameObject enemy;
    
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
            //Hp.instance.playerHp -= .01f;
        }
    }

    void CheckDanceInput()
    {
        if (Input.GetButtonDown("Dance1"))
        { 
            SetDance(1);
            // start dance3
        }else if(Input.GetButtonUp("Dance1"))
        { 
            SetDance(0);
        }

        if (Input.GetButtonDown("Dance2"))
        { 
             SetDance(2);
            
            // start dance3
        }else if(Input.GetButtonUp("Dance2"))
        { 
            SetDance(0);
        }

        if (Input.GetButtonDown("Dance3"))
        {  
             SetDance(3);
            // start dance3
        }else if(Input.GetButtonUp("Dance3"))
        { 
             SetDance(0);
        }
    }

    void SetDance(int danceType)
    {
        sprite.sprite = mySprite[danceType];
        DanceState = danceType;
    }

    public bool BadDancing()
    {
        // see if your dance is the same or punishment is disabled
        if(DanceState == DanceGoal || DanceGoal == 5)
        {
            //print(DanceGoal);
            //enemy.GetComponent<EnemyHp>().hp -= 1;
            return(false);
        }else
        {
            return(true);
        }
    }
}
