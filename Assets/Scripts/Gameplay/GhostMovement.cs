using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMovement : MonoBehaviour
{
    public float moveSpeed, acceleration;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Incremental());
    }

    // Update is called once per frame
    void Update()
    {
        //moveSpeed += Time.deltaTime + acceleration;
        //GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        transform.position += transform.right * Time.deltaTime * moveSpeed;
    }

    IEnumerator Incremental()
    {
        while (true)
        {
            //Wait for 30 seconds
            yield return new WaitForSeconds(2);

            //Increment Speed
            incrementSpeed();
        }
    }

    void incrementSpeed()
    {
        moveSpeed += acceleration;
    }
}
