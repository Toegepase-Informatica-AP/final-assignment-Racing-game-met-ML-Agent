﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerEnd : MonoBehaviour
{
    public float countdown = 5;
    void Update()
    {
        countdown = countdown - Time.deltaTime;

        if (countdown < 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
