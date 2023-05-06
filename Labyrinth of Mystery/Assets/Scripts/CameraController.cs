using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    // Update is called once per frame
    public void Update()
    {
        transform.position =  new Vector3(player.position.x, player.position.y, transform.position.z);   
    }
}