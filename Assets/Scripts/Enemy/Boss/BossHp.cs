using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHp : MonoBehaviour
{
    public Slider hpbar;
    private float _hp = 6;
    public Animator bossAnimator;


 
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
            if (CinematicBarsController.Instance != null)
            {
                CinematicBarsController.Instance.HideBars();
            }

            bossdefeat();
        }
        
    }

    public void bossdefeat()
    {
        bossAnimator.SetTrigger("BossDefeat");
    }


}
