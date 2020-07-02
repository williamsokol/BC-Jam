using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public float time;

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
        //musikPlayer.clip = traks[trakNumber].song;
        //musikPlayer.Play();
    }

     void Update()
    {
        //time += Time.deltaTime;
        if (!musikPlayer.isPlaying & trakNumber < traks.Length)
        {
            
            chordPlayer.sounds = traks[trakNumber].chords;
            musikPlayer.clip = traks[trakNumber].song;
            musikPlayer.Play();
            trakNumber++;
            MusicEvents.SetInteger("Song",trakNumber);

        }else if (!musikPlayer.isPlaying & trakNumber == traks.Length)
        {
            trakNumber = 0;
        }
    }

    void StartDance()
    {
       
        platformDance.DoDance();
        //print(time);
        time = 0;
    }

    public void playChord(int pickedChord)
    {
        print ("test");
        chordPlayer.SFXChords(pickedChord);
    }

}
