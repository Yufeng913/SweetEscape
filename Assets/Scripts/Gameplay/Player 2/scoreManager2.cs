﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager2 : MonoBehaviour
{
    public static int score;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();

        score = 0;
    }

    void Update()
    {
        if (score < 0)
            score = 0;

        text.text = "" + score;
    }

    public static void AddPoints(int pointsToAdd2)
    {
        score += pointsToAdd2;
    }

    public static void Reset()
    {
        score = 0;
    }
}
