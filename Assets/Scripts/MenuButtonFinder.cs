using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonFinder : MonoBehaviour
{
    public LevelLoader levelLoader;
    // Start is called before the first frame update
    void Start()
    {
        levelLoader = GameObject.Find("GameController").GetComponent<LevelLoader>();
    }

    // Update is called once per frame
    public void LoadMenu()
    {
        levelLoader.LoadNextLevel("MainMenu");     
    }
}
