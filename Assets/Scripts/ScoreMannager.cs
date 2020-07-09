using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMannager : MonoBehaviour
{

    public static ScoreMannager instance;
    public Text text;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore (int coinValue)
    {
        score += coinValue;
        text.text = "X"+score.ToString();
    }


}
