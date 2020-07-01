using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDance : MonoBehaviour
{
    int pickedDance;

    public Sprite[] enemySprites;
    public SpriteRenderer sprite;

    public WaitForSeconds danceGap = new WaitForSeconds(.5f);
    public WaitForSeconds danceSpeed = new WaitForSeconds(1);

    void Start()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
        //print(danceGap);
    }


    public void StartDanceOff(GameObject player)
    {

        //turn off standard dance
        
        StartCoroutine("SetDanceGoal");
        
    }

    IEnumerator SetDanceGoal()
    {
        while(true)
        {
            //goal of 5 mean take no dmg
            PlayerDance.DanceGoal = 5; 
            
            //play animation
            pickedDance = Random.Range(1,4);
            SetDance(pickedDance);

            yield return danceGap;

            PlayerDance.DanceGoal = pickedDance;

            yield return danceSpeed;
        }
    }

    void SetDance(int danceType)
    {
        sprite.sprite = enemySprites[danceType];
        //PlayerDance.DanceGoal = pickedDance;
    }
   
  
}
