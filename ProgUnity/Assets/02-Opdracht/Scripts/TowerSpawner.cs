
using UnityEngine;


public class TowerSpawner: MonoBehaviour
{
    public GameObject Towers;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            SpawnTower();
        }
    }

    void SpawnTower()
    {
        float x = Random.Range(-5, 5);
        float y = Random.Range(-5, 5);
        float z = Random.Range(-5, 5);

        Vector3 RandomPos = new Vector3(x, 0, z);
        GameObject Tower = Instantiate(Towers, RandomPos, Quaternion.identity   );

        
    }

 
}
