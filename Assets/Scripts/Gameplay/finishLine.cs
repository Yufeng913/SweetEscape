using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishLine : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Maggie the Mint")
        {
            SceneManager.LoadScene("Player1Wins");
        }

        if (other.name == "Maggie the Mint (Player2)")
        {
            SceneManager.LoadScene("Player2Wins");
        }
    }
}
