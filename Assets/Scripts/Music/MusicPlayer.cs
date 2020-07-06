using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    

    public SFX chordPlayer;
    public PlatformDance platformDance;

    private AudioSource musikPlayer;
    public int          trakNumber;
    public  MusicTrack[] traks;
    public Animator MusicEvents;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        musikPlayer = GetComponent<AudioSource>();
        trakNumber  = 0;
        MusicEvents = GetComponent<Animator>();
        //StartDance();   
        
    }

     void Update()
    {
    
        if (!musikPlayer.isPlaying & trakNumber < traks.Length)
        {
           
            chordPlayer.sounds = traks[trakNumber].chords;
            musikPlayer.clip = traks[trakNumber].song;
            musikPlayer.Play();
            
            //find chord timings from music track script    
            foreach(float time in traks[trakNumber].times)
            {
                Invoke("StartDance", time);
            }

            trakNumber++;

        }else if (!musikPlayer.isPlaying & trakNumber == traks.Length)
        {
            trakNumber = 0;
        }
    }

    void StartDance()
    {
        
        platformDance.DoDance();
       
    }

    public void playChord(int pickedChord)
    {
//        print ("test");
        chordPlayer.SFXChords(pickedChord);
    }

}
