using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wrapperManager : MonoBehaviour
{
    public static int candyWrappers;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();

        candyWrappers = 0;
    }

    void Update()
    {
        if (candyWrappers < 0)
            candyWrappers = 0;

        text.text = "" + candyWrappers;
    }

    public static void AddPoints(int pointsToAdd)
    {
        candyWrappers += pointsToAdd;
    }

    public static void Reset()
    {
        candyWrappers = 0;
    }
}
