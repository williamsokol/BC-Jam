using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialSpecial : MonoBehaviour
{

    public GameObject sfxObject;
    // Start is called before the first frame update
    void Start()
    {
        //sfxObject = GameObject.Find("Sfx 1");

    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        //print("test");
        if(other.tag == "Player")
        {
            sfxObject.SetActive(true);
        }
    }
}
