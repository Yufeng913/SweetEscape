using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyPickup : MonoBehaviour
{
    public int pointsToAdd;

    public AudioSource collectedSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>() == null)
            return;

        ScoreManager.AddPoints(pointsToAdd);

        collectedSound.Play();

        Destroy(gameObject);
    }
}
