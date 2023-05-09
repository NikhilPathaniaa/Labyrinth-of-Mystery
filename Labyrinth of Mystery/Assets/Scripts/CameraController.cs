using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform pink_Man;
    // Update is called once per frame
    public void Update()
    {
        transform.position =  new Vector3(player.position.x, player.position.y, transform.position.z);  
        transform.position =  new Vector3(pink_Man.position.x, pink_Man.position.y, transform.position.z); 
    }
}
