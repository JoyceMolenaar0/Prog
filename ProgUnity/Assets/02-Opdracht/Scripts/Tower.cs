using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        float YScale = Random.Range(0.5f, 2);
        Vector3 RandomScale = new Vector3(1, YScale, 1);
        transform.localScale = RandomScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
