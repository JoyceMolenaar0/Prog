using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float WalkSpeed = 2f;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position += (transform.forward * WalkSpeed * Time.deltaTime);
    }
}
