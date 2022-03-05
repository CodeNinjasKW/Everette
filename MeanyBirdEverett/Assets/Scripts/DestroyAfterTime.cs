﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    //after this time, the object will be destroyed
    [Header("Default Destruction Time")]
    public float timeToDestruction;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyObject", timeToDestruction);

    }

    // Update is called once per frame
    void DestroyObject()
    {
        //destroy object
        Destroy(gameObject);

    }
}

