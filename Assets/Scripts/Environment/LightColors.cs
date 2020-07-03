using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightColors : MonoBehaviour
{
   public Color[] colors;
   public Material mat;
   public Color colorGoal;


    
    
    public void ShiftColor(int color)
    {
        colorGoal = colors[color];
        mat.SetColor ("_EmissionColor", colorGoal);
        //StartCoroutine("Shift");
        
    }
    
}
