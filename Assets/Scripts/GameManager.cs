using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    #region Fields

    private TextMeshProUGUI fpsText = null;

    #endregion

    #region Constructor

    private void Awake()
    {
        RefrenceManager.getSingleton.gameManagerRefrence = this;
        DontDestroyOnLoad(this);
    }

    #endregion

    #region Methods

    private void Start()
    {
        fpsText = RefrenceManager.getSingleton.uiManagerRefrence.fpsText;
    }

    private void Update()
    {
    //    fpsText.text = ((int)(1 / Time.deltaTime)).ToString();
    }

    #endregion

}
