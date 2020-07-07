using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGoal : MonoBehaviour
{
    public GameObject find;
    public LevelLoader levelLoader;

    // Start is called before the first frame update
    void Start()
    {
        
        levelLoader = GameObject.Find("GameController").GetComponent<LevelLoader>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        //print("you windawda");
        if (collision.gameObject.tag == "Player")
        {
           print("you win");


           levelLoader.LoadNextLevel("LoadingLevel");
        }
       
    }
}
