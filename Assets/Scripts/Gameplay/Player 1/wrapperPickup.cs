using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrapperPickup : MonoBehaviour
{
    public int pointsToAdd;
        
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>() == null)
            return;

        wrapperManager.AddPoints(pointsToAdd);

        Destroy(gameObject);
    }
}
