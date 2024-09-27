using UnityEngine;

public class DebugScript1 : MonoBehaviour
{
    private float Numbers = 0f;
    private bool TOF = false;
    void Start()
    {

    }


    void Update()
    {
        if (TOF == true && Numbers == 0f)
        {
            StopAll();
        }
    }

    void StopAll()
    {
        Numbers = 2f;
    }
}
