using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Switch : MonoBehaviour
{
     public bool option1;    // 
     public bool option2;    // 
     public bool option3;    // 
 
     public GameObject choice1;  // 
     public GameObject choice2;  // 
     public GameObject choice3;  // 
 
     void Start () 
     {
 
         choice1 = FindObjectOfType<GameObject>();  // gets access to the p1 game object
         choice2 = FindObjectOfType<GameObject>();  // gets access to the p2 game object
         choice3 = FindObjectOfType<GameObject>();  // gets access to the p3 game object
 
         if (option1 = true)
         {
             choice1.gameObject.SetActive(true);
             choice2.gameObject.SetActive(false);
             choice3.gameObject.SetActive(false);
             option2 = false;
             option3 = false;
         }
 
         if (option2 = true)
         {
             choice1.gameObject.SetActive(false);
             choice2.gameObject.SetActive(true);
             choice3.gameObject.SetActive(false);
             option1 = false;
             option3 = false;
         }
 
         if (option3 = true)
         {
             choice1.gameObject.SetActive(false);
             choice2.gameObject.SetActive(false);
             choice3.gameObject.SetActive(true);
             option1 = false;
             option2 = false;
         }
     }
     
     void Update () 
     {
         if (option1 = true)
         {
             choice1.gameObject.SetActive(true);
             choice2.gameObject.SetActive(false);
             choice3.gameObject.SetActive(false);
             option2 = false;
             option3 = false;
         }
 
         if (option2 = true)
         {
             choice1.gameObject.SetActive(false);
             choice2.gameObject.SetActive(true);
             choice3.gameObject.SetActive(false);
             option1 = false;
             option3 = false;
         }
 
         if (option3 = true)
         {
             choice1.gameObject.SetActive(false);
             choice2.gameObject.SetActive(false);
             choice3.gameObject.SetActive(true);
             option1 = false;
             option2 = false;
         }
     }
     
 }