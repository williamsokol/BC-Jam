﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOrientation : MonoBehaviour
{
    private Animator animation;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
        animation.SetFloat("DanceOffset", Random.Range(0, 1f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
