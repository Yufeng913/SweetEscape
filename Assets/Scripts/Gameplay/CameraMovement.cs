﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// I got this piece of code from: 
// https://answers.unity.com/questions/674225/2d-camera-to-follow-two-players.html

public class CameraMovement : MonoBehaviour
{
    //public float moveSpeed;
    public Transform player1, player2;
    public float minSizeY = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void SetCameraPos()
    {
        Vector3 middle = (player1.position + player2.position) * 0.5f;

        GetComponent<Camera>().transform.position = new Vector3(
            middle.x,
            GetComponent<Camera>().transform.position.y,
            GetComponent<Camera>().transform.position.z
            );
    }

    void SetCameraSize()
    {
        //horizontal size is based on actual screen ratio
        float minSizeX = minSizeY * Screen.width / Screen.height;

        //multiplying by 0.5, because the ortographicSize is actually half the height
        float width = Mathf.Abs(player1.position.x  - player2.position.x ) *0.5f;
        float height = Mathf.Abs(player1.position.y - player2.position.y) * 0.5f;

        //computing the size
        float camSizeX = Mathf.Max(width, minSizeX);
        GetComponent<Camera>().orthographicSize = Mathf.Max(height,
            camSizeX * Screen.height / Screen.width, minSizeY);
    }

    // Update is called once per frame
    void Update()
    {
        SetCameraPos();
        SetCameraSize();
    }
}
