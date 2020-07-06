using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDance : MonoBehaviour
{
    
    public WaitForSeconds danceGap = new WaitForSeconds(.7f);
    public MusicPlayer musicPlayer;
    public void DoDance()
    {
        print("test");
        if(EnemyDance.isDanceOff == false)
            StartCoroutine("Dance");
    }

    
    IEnumerator Dance()
    {
        //isDanceOff = true;
        //currentEnemy = this.gameObject;

        
        //goal of 5 mean take no dmg
        PlayerDance.DanceGoal = 5; 
        
        //play animation
        int pickedDance = Random.Range(1,4);
        SetDanc(pickedDance);

        yield return danceGap;

        PlayerDance.DanceGoal = pickedDance;
        // if player danced before the dance gap ended
        if(PlayerDance.DanceState != PlayerDance.DanceGoal)
        {
            Hp.instance.playerHp -= 1; 
        }
        
        StopCoroutine("Dance");
        
    }

    void SetDanc(int pickedDance)
    {
        //play music que
        print("Dance");
        musicPlayer.playChord(pickedDance);
        //change light colors
        GetComponent<LightColors>().ShiftColor(pickedDance-1);  
        //

    }
}
