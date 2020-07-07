using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
   public Animator animator;
   public float animLength;

    void Start()
    {
        animator = GetComponent<Animator>();
        //animLength = 
        
    }

  public void FadeOut()
  {
      animator.SetTrigger("LoadingScene");
  }
}
