using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public GameObject fade;
    private Fade fadeScript;
    private GameObject musicPlayer;
    private MusicPlayer musicScript;
    

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        
        
    }

    public void LoadNextLevel(string level){
        
        musicPlayer = GameObject.Find("Music Player");
        if (musicPlayer != null){
            musicScript = musicPlayer.GetComponent<MusicPlayer>();
            musicScript.FadeMusic();
        }//else{Debug.LogError("no MusicPlayer in scene");}
        fade = GameObject.Find("Fade");
        if(fade != null){
            fadeScript = fade.GetComponent<Fade>();
            fadeScript.FadeOut();
        }//else{Debug.LogError("no fade in scene");}


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
