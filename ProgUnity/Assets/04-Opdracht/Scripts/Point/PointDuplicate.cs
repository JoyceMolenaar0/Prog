using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointDuplicate : MonoBehaviour
{
    [SerializeField] GameObject Point;
    [SerializeField] GameObject Player;
    private GameObject PointClone;
    private float CloneCount;

    void Start()
    {
        
    }

   
    void Update()
    {
        if (CloneCount < 4)
        {
            CreatePoint();
        }



    }

    void CreatePoint()
    {
        PointClone = Instantiate(Point);
        CloneCount++;


        float x = Random.Range(-20f,20f);
        float y = Random.Range(-20f,20f);
        float z = Random.Range(-20f,20f);

        Vector3 RandomPos = new Vector3(x, 0, z);
        PointClone.transform.position = RandomPos;
    }
}
