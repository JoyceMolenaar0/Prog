
using Unity.VisualScripting;
using UnityEngine;


public class Duplication : MonoBehaviour
{
    [SerializeField] GameObject BallPrefab;

    private float ElapsedTime = 0f;

    private void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            CreateBall();
        }
    }

     void Update()
    {


        ElapsedTime += Time.deltaTime;
        if (ElapsedTime > 1.5f)
        {
            CreateBall();
            ElapsedTime = 0f;

        } 
        
    }

    void CreateBall()
    {

        GameObject Ball = Instantiate(BallPrefab);
        Material material = Ball.GetComponent<MeshRenderer>().material;
        Renderer ballRenderer = Ball.GetComponent<Renderer>();

       

        float x = Random.Range(-5f, 5f);
        float y = Random.Range(-5f, 5f);
        float z = Random.Range(-5f, 5f);

        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);



        Vector3 RandomPos = new Vector3 (x, y, z);
        Color RandomCol = new Color (r, g, b, 1f);


        

        Ball.transform.position = RandomPos;
        ballRenderer.material.color = RandomCol;

        DestroyBall(Ball);

    }

    void DestroyBall(GameObject Ball)
    {
        Destroy(Ball, 2f);
    }
}