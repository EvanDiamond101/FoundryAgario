﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POOF_FX : MonoBehaviour
{
    private float Timer = 0.0f;

    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer > 2.4f)
        {
            Destroy(this.gameObject);
        }
    }
}
