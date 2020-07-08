using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    //int count =0;
    private AudioSource soundPlayer;
    public AudioClip[] sounds;
    public AudioClip playerHurtNoise;
    public AudioClip enemyHurtNoise;
    //public AudioClip playerJumpNoise;
    // Start is called before the first frame update
    void Awake()
    {
        soundPlayer = GetComponent<AudioSource>();

    }


    

    public void SFXChords(int chord)
    {
        print(chord);
        //count++;
        soundPlayer.clip = sounds[chord-1];
        soundPlayer.Play();
    }

    public void PlayerHurt()
    {
        soundPlayer.clip = playerHurtNoise;
        soundPlayer.Play();
    }
    public void EnemyHurt()
    {
        soundPlayer.clip = enemyHurtNoise;
        soundPlayer.Play();
    }
    
    
}
