using System.Collections;
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
    public SpriteRenderer sprite;

    public WaitForSeconds danceGap = new WaitForSeconds(.6f);
    public WaitForSeconds danceSpeed = new WaitForSeconds(.5f);

    void Start()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
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
                print("test");
                enemyHp.hp -= 1;
            }else
            {
                Hp.instance.playerHp -= 1; 
            }

            yield return danceSpeed;
        }
    }

    void SetDance(int danceType)
    {
        sprite.sprite = enemySprites[danceType];
        //PlayerDance.DanceGoal = pickedDance;
    }
   
  
}
