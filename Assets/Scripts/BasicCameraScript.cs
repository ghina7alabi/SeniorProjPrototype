﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCameraScript : MonoBehaviour
{
    public GameObject character;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(0, character.transform.position.y, -10);
    }
}