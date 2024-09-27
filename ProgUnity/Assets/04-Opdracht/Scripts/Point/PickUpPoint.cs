using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpPoint : MonoBehaviour
{

    private void Start()
    {
        
    }
    void OnTriggerEnter(Collider Player)
    {
        
        if (Player.CompareTag("PlayerCube"))
        {
           Destroy(gameObject); 
        }
    }
}