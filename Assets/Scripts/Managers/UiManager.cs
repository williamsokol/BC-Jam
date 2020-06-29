using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    #region Fields

    public TextMeshProUGUI fpsText;
    public Animator transistion;

    #endregion
    

    #region Constructor

    private void Awake()
    {
        RefrenceManager.getSingleton.uiManagerRefrence = this;
        DontDestroyOnLoad(this);
    }

    #endregion

    public void LoadNextLevel()
    {
        FindObjectOfType<AudioManager>().Play("music");
        StartCoroutine(Starting(SceneManager.GetActiveScene().buildIndex + 1));
        
    }

   
    IEnumerator Starting(int buildIndex)
    {

        //transistion.SetTrigger("LoadingScene");

        yield return new WaitForSeconds(2);

        SceneManager.LoadScene(buildIndex);
    }

}
