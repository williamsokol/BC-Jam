using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Fade fade;
    private GameObject musicPlayer;
    private MusicPlayer musicScript;
    

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        
        
    }

    public void LoadNextLevel(string level){
        
        musicPlayer = GameObject.Find("Music Player");
        print(musicPlayer);
        if (musicPlayer != null){
            musicScript = musicPlayer.GetComponent<MusicPlayer>();
            musicScript.FadeMusic();
        }
        fade = GameObject.Find("Fade").GetComponent<Fade>();
        if(fade != null)
            fade.FadeOut();
       


        // do the function put as a parameter in this one
        Invoke(level, 1.5f);
        
    }
    void LoadingLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void LoseLevel()
    {
        SceneManager.LoadScene("LossScene");
    }
}
