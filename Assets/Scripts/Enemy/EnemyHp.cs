using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHp : MonoBehaviour
{
    public SFX sfx2;
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
        sfx2 = GameObject.Find("Sfx 2").GetComponent<SFX>();
        hpbar.maxValue = _hp;
    }


     public void UpdateHp()
    {
        hpbar.value = _hp;
        sfx2.EnemyHurt();

        if(_hp <= 0)
        {
            if (CinematicBarsController.Instance != null)
            {
                CinematicBarsController.Instance.HideBars();
            }
                
            Die();
        }
        
    }
    public void Die(){
        
        Destroy(gameObject);
        EnemyDance.isDanceOff = false;
    }

    
}
