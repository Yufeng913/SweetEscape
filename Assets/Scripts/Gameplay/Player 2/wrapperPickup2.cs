using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrapperPickup2 : MonoBehaviour
{
    public int pointsToAdd;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController2>() == null)
            return;

        wrapperManager2.AddPoints(pointsToAdd);

        Destroy(gameObject);
    }
}
