using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Fade fade;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        
        print(fade);
    }

    public void LoadNextLevel(){
        fade = GameObject.Find("Fade").GetComponent<Fade>();
        fade.FadeOut();
        Invoke("LoadingLevel", 1f);
        
    }
    void LoadingLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Lose()
    {
        fade = GameObject.Find("Fade").GetComponent<Fade>();
        print(fade);
        fade.FadeOut();
        Invoke("LoseLevel",1);
    }
    void LoseLevel()
    {
        SceneManager.LoadScene("LossScene");
    }
}
