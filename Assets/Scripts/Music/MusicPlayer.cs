using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    

    public SFX chordPlayer;
    public SFX sfxPlayer;
    public PlatformDance platformDance;

    // the time is a little off in unity for some reason    
    public float musicOffset;
    private AudioSource musikPlayer;
    public int          trakNumber;
    public  MusicTrack[] traks;
    public Animator MusicEvents;

    void Awake()
    {
        //DontDestroyOnLoad(gameObject);
        musikPlayer = GetComponent<AudioSource>();
        trakNumber  = 0;
        MusicEvents = GetComponent<Animator>();
        platformDance = GameObject.Find("GameManager").GetComponent<PlatformDance>();
        //StartCoroutine(DieMusic(1));   
        
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
                Invoke("StartDance", time + musicOffset);
            }

            trakNumber++;

        }else if (!musikPlayer.isPlaying & trakNumber == traks.Length)
        {
            trakNumber = 0;
        }
    }

    void StartDance()
    {
        
        platformDance.DoDance(this);
       
    }

    public void playChord(int pickedChord)
    {
//        print ("test");
        chordPlayer.SFXChords(pickedChord);
    }
    
    public void FadeMusic()
    {
        StartCoroutine(DieMusic(1));
    }


    public IEnumerator DieMusic ( float FadeTime) {
        float startVolume = musikPlayer.volume;
 
        //print("test");
        while (musikPlayer.volume > 0) {
            musikPlayer.volume -= startVolume * Time.deltaTime / FadeTime;
 
            yield return null;
        }
 
        
        //audioSource.volume = startVolume;
    }


}
