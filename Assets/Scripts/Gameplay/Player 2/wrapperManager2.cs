using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wrapperManager2 : MonoBehaviour
{
    public static int candyWrappers2;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();

        candyWrappers2 = 0;
    }

    void Update()
    {
        if (candyWrappers2 < 0)
            candyWrappers2 = 0;

        text.text = "" + candyWrappers2;
    }

    public static void AddPoints(int pointsToAdd)
    {
        candyWrappers2 += pointsToAdd;
    }

    public static void Reset()
    {
        candyWrappers2 = 0;
    }
}