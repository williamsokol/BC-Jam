using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    private Vector2 velocity;
    public  GameObject  player;
    private Vector3        offset;

    
    public void getCamera()
    {      
            //player = Player.instance;
            //offset = player.transform.position - transform.position;
            velocity = Vector2.zero;
            print("offset");
    }
    void FixedUpdate()
    {
        if(player != null)
            transform.position = Vector2.SmoothDamp(transform.position,ChooseTarget(),ref velocity,.4f);
    }
    Vector2 ChooseTarget()
    {
        if(EnemyDance.isDanceOff == true)
        {
            //I subtract .5 here cause the there is .5 on the cameras transform, because it looks better that way out of combat
            Vector2 thing = (player.transform.position + EnemyDance.currentEnemy.transform.position) /2;
            thing.x -=.5f;
            return thing;
        }
        
        return player.transform.position;
    }
}
