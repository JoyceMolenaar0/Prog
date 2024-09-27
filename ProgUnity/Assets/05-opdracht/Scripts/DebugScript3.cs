using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugScript3 : MonoBehaviour
{
    private string EnemiesTalk = "Take Cover";
    private float Enemies = 0f;
    void Start()
    {

    }

    private void Update()
    {
        if (EnemiesTalk == "Cover")
        {
            Enemies++;
        }
    }

}
