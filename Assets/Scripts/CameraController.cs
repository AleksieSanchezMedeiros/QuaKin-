﻿//Aleksie




using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public Transform Player;

    private Vector3 offset;            //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start()
    {
        Player = GameObject.FindObjectOfType<Player>().transform;
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - Player.position;

    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        if (!Player)
        {
            Player = GameObject.FindObjectOfType<Player>().transform;
        }
        else
        {
            // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
            offset.x += Mathf.Deg2Rad * Mathf.Sin(Time.realtimeSinceStartup * 10);
            transform.position = Player.position + offset;
        }


    }
}
