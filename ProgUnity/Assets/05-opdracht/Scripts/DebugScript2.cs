using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugScript2 : MonoBehaviour
{
    [SerializeField] GameObject Player;
    private int EnemyCount = 0;
    private float WalkSpeed = 3f;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (EnemyCount == 5)
        {
            Player.transform.position = Vector3.forward * WalkSpeed * Time.deltaTime;
        }
    }
}
