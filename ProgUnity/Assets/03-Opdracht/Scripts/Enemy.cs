using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float WalkSpeed = 2f;
    void Update()
    {
        transform.position += (transform.forward * WalkSpeed * Time.deltaTime);
    }
}
