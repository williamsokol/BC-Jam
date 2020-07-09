using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHp : MonoBehaviour
{
    public Slider hpbar;
    private float _hp = 6;
    public Animator bossAnimator;
    public SFX sfx2;


 
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
        //sfx2 = GameObject.Find("Sfx 2").GetComponent<SFX>();
        //print(sfx2);
    }


     public void UpdateHp()
    {
        hpbar.value = _hp;
        //sfx2.BossHurt();
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
        sfx2.BossDead();
        BossDance.isDanceOff = false;
        Destroy(this.gameObject);
        Destroy(sfx2.gameObject.transform.parent.gameObject);
    }


}
