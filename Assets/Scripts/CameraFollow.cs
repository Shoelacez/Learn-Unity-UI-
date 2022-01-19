using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    private Vector3 temPos;
    void LateUpdate()
    {
        temPos=transform.position;
        temPos.x=player.transform.position.x;

        transform.position=temPos;
    }
}
