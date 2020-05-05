using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killPlayer2 : MonoBehaviour
{

    public LevelManager2 levelManager2;

    // Start is called before the first frame update
    void Start()
    {
        levelManager2 = FindObjectOfType<LevelManager2>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (/* other.name == "Ghost" || other.name == "Cauldron" || */other.name == "Kid")
        {
            levelManager2.GameOver();
        }
    }
}
