using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    private AudioSource soundPlayer;
    public AudioClip[] sounds;
    // Start is called before the first frame update
    void Awake()
    {
        soundPlayer = GetComponent<AudioSource>();

    }


    

    public void SFXChords(int chord)
    {
        print("this is " + chord);
        soundPlayer.clip = sounds[chord-1];
        soundPlayer.Play();
    }
    
}
