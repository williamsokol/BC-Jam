using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hp : MonoBehaviour
{

    public Slider hpbar;
    public float _playerHp = 4;

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
            _playerHp = value;
            UpdateHp();
        }
    }

    public void UpdateHp()
    {
        hpbar.value = playerHp;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
