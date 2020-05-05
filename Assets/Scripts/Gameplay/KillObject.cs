using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillObject : MonoBehaviour
{
    public AudioSource deathSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Kid")
        {
            deathSound.Play();
            Destroy(gameObject);
        }
    }
}
