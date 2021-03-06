﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDance : MonoBehaviour
{
    static public bool isDanceOff;
    static public GameObject currentEnemy;

    int pickedDance;
    public EnemyHp enemyHp;
    public GameObject player;

    public Sprite[] enemySprites;
    public Animator spriteAnim;

    public WaitForSeconds danceGap;
    public float danceGapTime;
    public WaitForSeconds danceSpeed = new WaitForSeconds(.5f);

    void Start()
    {
        isDanceOff = false;
        spriteAnim = GetComponentInChildren<Animator>();
        danceGap = new WaitForSeconds(danceGapTime);
        //print(danceGap);
    }


    public void StartDanceOff()
    {
        
        //turn off standard dance
        StopCoroutine("DanceOff");
        StartCoroutine("DanceOff");
        
    }

    IEnumerator DanceOff()
    {
        isDanceOff = true;
        currentEnemy = this.gameObject;

        while(true)
        {
            //goal of 5 mean take no dmg
            PlayerDance.DanceGoal = 5; 
            
            //play animation
            pickedDance = Random.Range(1,4);
            
            
            SetDance(pickedDance);

            yield return danceGap;

            PlayerDance.DanceGoal = pickedDance;
            // if player danced before the dance gap ended
            if(PlayerDance.DanceState == PlayerDance.DanceGoal)
            {
//                print("test");
                enemyHp.hp -= 1;
            }else
            {
                while(PlayerDance.DanceState != PlayerDance.DanceGoal)
                {
                    Hp.instance.playerHp -= .2f;
                    yield return danceSpeed;
                }
            }


            yield return danceSpeed;
        }
    }

    void SetDance(int danceType)
    {
        spriteAnim.SetInteger("DanceType",danceType);
        print(danceType);
        GameObject.Find("GameManager").GetComponent<LightColors>().ShiftColor(pickedDance-1);
        //PlayerDance.DanceGoal = pickedDance;
    }
   
  
}
