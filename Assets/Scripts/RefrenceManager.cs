using UnityEngine;

public class RefrenceManager : MonoBehaviour
{

    #region Fields

    //Ui Manager Refrence
    public UiManager uiManagerRefrence = null;

    //Asset Manager Refrence
    public AssetManager assetManagerRefrence = null;

    //Game Manager Refrence
    public GameManager gameManagerRefrence = null;

    //Singeleton Variable
    public static RefrenceManager getSingleton = null;

    #endregion

    #region constructor

    private void Awake()
    {
        if(getSingleton == null)
        {
            getSingleton = this;
        }else{
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this);
    }

    #endregion

}
