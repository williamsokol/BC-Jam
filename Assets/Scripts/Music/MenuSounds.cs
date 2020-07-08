using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSounds : MonoBehaviour
{
    //int count =0;
    private AudioSource soundPlayer;

    public AudioClip loadLevelNoise;
    //public AudioClip playerJumpNoise;
    // Start is called before the first frame update
    void Awake()
    {
        soundPlayer = GetComponent<AudioSource>();

    }


    public void MenuNoise()
    {
        soundPlayer.clip = loadLevelNoise;
        soundPlayer.Play();
    }
    
    
}