using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candyPickup2 : MonoBehaviour
{
    public int pointsToAdd;

    public AudioSource collectedSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController2>() == null)
            return;

        scoreManager2.AddPoints(pointsToAdd);

        collectedSound.Play();

        Destroy(gameObject);
    }
}