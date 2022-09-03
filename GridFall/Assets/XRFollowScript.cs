using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRFollowScript : MonoBehaviour
{
    //This is used to follow the playes movement around the game world
    public Transform player;
    public Vector3 offset;

    void Update()
    {
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z); // Camera follows the player with specified offset position
    }
}
