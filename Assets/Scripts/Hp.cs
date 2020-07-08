using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hp : MonoBehaviour
{

    private bool dying = false;
    public Slider hpbar;
    public float _playerHp = 8;

    static public Hp instance;

    // Start is called before the first frame update
    void Start()
    {
        hpbar = gameObject.GetComponent<Slider>();
        instance = this;
    }
    
    // runs every time playerHp is changed
    public float playerHp
    {
        get {return _playerHp;}
        set {
            //print(playerHp);
            _playerHp = value;
            UpdateHp();
        }
    }

    public void UpdateHp()
    {
        
        hpbar.value = playerHp;
        //print(playerHp);
        if(playerHp <= 0 && dying == false)
        {
            print("dead");
            Die();
            dying = true;
        }
    }
    public void Die(){
        
        
        GameObject.Find("GameController").GetComponent<LevelLoader>().LoadNextLevel("LoseLevel");

        //EnemyDance.isDanceOff = false;
    }
}
