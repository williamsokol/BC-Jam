using UnityEngine;

public class AssetManager : MonoBehaviour
{

    #region Fields

    //Add all sprites here as public field

    #endregion

    #region Constructor

    private void Awake()
    {
        RefrenceManager.getSingleton.assetManagerRefrence = this;
        DontDestroyOnLoad(this);
    }

    #endregion

}
