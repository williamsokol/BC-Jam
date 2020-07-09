using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {

        {
            if (other.gameObject.tag == "Player")
            {
                ScoreMannager.instance.ChangeScore(coinValue);
                Destroy(this.gameObject);
            }

        }
    }


}
