﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movedown : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, speedgoloba.speed, 0);
    }
}
