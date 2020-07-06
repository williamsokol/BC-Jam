using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetecter : MonoBehaviour
{
    public EnemyDance enemyDance;
    

    // Start is called before the first frame update
    void Start()
    {
        //print("test1");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //print("test");
        if (other.gameObject.tag == "Player")
        {   
            if (CinematicBarsController.Instance != null)
            {
                CinematicBarsController.Instance.ShowBars(); //Make the Cinematic bars transition that will end when enemy hp is under 0
            }
            
            //give both objects ref to each other and start the dance
            enemyDance.StartDanceOff();
        }
    }
}
