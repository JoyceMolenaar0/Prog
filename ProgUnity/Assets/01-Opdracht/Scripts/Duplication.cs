using UnityEngine;

public class Duplication : MonoBehaviour
{
    [SerializeField] GameObject BallPrefab;
    private float ElapsedTime = 0f;

    private void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Color color = RandomColor();
            Vector3 randPos = RandomPosition(-10f, 10f);
            GameObject ball = CreateBall(color, randPos);
            DestroyBall(ball);
        }
    }
    private void Update()
    {
        ElapsedTime += Time.deltaTime;
        if (ElapsedTime > 1.5f)
        {
            Color color = RandomColor();
            Vector3 randPos = RandomPosition(-10f, 10f);
            GameObject ball = CreateBall(color, randPos);
            DestroyBall(ball);

            ElapsedTime = 0f;
        }
    }
    private GameObject CreateBall(Color c, Vector3 position)
    {
        GameObject ball = Instantiate(BallPrefab, position, Quaternion.identity);
        Renderer ballRenderer = ball.GetComponent<Renderer>();

        ballRenderer.material.color = c;

        return ball; 
    }

    private void DestroyBall(GameObject ball)
    {
        Destroy(ball, 2f);
    }
    private Color RandomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        return new Color(r, g, b, 1f);
    }

    private Vector3 RandomPosition(float min, float max)
    {
        float x = Random.Range(min, max);
        float y = Random.Range(min, max);
        float z = Random.Range(min, max);
        return new Vector3(x, y, z);
    }
}