using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyPrefab : MonoBehaviour
{
    public GameObject EnemyPrefab;
    void stopDance()
    {

        BossDance.isDanceOff = false;

    }


    public void Die()
    {

        Destroy(EnemyPrefab);
    }
}
