using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHp : MonoBehaviour
{
    public Slider hpbar;
    private float _hp = 6;

 
    public float hp
    {
        get{return _hp;}

        set{
            _hp = value;
            UpdateHp();
        }
    }

    void Start()
    {
        hpbar.maxValue = _hp;
    }


     public void UpdateHp()
    {
        hpbar.value = _hp;
        if(_hp <= 0)
        {
            Die();
        }
        
    }
    public void Die(){
        
        Destroy(gameObject);
        EnemyDance.isDanceOff = false;
    }

    
}
