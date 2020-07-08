using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{

    public float ObstacleDamage = .5f;
    public float WinkDuration = .1f;
    public SpriteRenderer playerGO;
    // Start is called before the first frame update
    private void Awake()
    {
        playerGO = this.GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D CollisionInfo)
    {
        if (CollisionInfo.collider.tag == "Obstacle")
        {
            //Debug.Log("i hit an obstacle");
            Hp.instance.playerHp -= ObstacleDamage;
            StartCoroutine("WinkSprite");
        }
    }
   
    IEnumerator WinkSprite()
    {
        
        if (playerGO != null && playerGO.enabled == true)
        {
            playerGO.enabled = false;
        }
        yield return new WaitForSeconds (WinkDuration);

        if (playerGO != null && playerGO.enabled == false)
        {
            playerGO.enabled = true;
        }

    }
}
