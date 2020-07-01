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
        if(other.gameObject.tag == "Player")
        {
            //print("starting dance");
            enemyDance.StartDanceOff(other.gameObject);
        }
    }
}
