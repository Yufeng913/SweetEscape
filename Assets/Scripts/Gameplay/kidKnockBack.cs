using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kidKnockBack : MonoBehaviour
{
    public float knockBack;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Candy Wrapper(Clone)" || other.name == "Candy Wrapper2(Clone)")
        {
            //Destroy(gameObject);
            //transform.position += transform.forward * Time.deltaTime * knockBack;
            transform.Translate(new Vector2(-2, 0), Space.World);
        }
    }
}
