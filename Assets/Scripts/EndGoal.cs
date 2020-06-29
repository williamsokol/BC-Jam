using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGoal : MonoBehaviour
{
    public GameObject find;
    //public UiManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
       find = GameObject.Find("Manager Holder");
       //uiManager = find.GetComponent<UiManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        print("you windawda");
        if (collision.gameObject.tag == "Player")
        {
           print("you win");

           //uiManager.LoadNextLevel();
        }
       
    }
}
