using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnObject;
    [SerializeField] private float spawnRadius = 10;
    [SerializeField] private int spawnCount = 3;

    void Start()
    {
        Spawn(spawnObject, spawnRadius, spawnCount);
    }

    private void Spawn(GameObject obj, float radius, int count)
    {
        for(int i = 0; i < count; i++)
        {
            float randomX = Random.Range(-radius,radius);
            float randomY = Random.Range(-radius,radius);

            Vector2 position = new Vector2(transform.position.x + randomX, transform.position.y + randomY);

            Instantiate(obj, position, Quaternion.identity);
        }
    }
}
