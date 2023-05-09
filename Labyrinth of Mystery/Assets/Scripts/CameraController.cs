using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    // [SerializeField] private Transform pink_Man;
    // [SerializeField] private Transform ninja_frog;
    // [SerializeField] private Transform mask_dude;
    // // Update is called once per frame
    public void Update()
    {
        transform.position =  new Vector3(player.position.x, player.position.y, transform.position.z);  
        // transform.position =  new Vector3(pink_Man.position.x, pink_Man.position.y, transform.position.z);
        // transform.position =  new Vector3(ninja_frog.position.x, ninja_frog.position.y, transform.position.z);  
        // transform.position =  new Vector3(mask_dude.position.x, mask_dude.position.y, transform.position.z);   
    }
}
