using UnityEngine;

public class RandomItemSpawner : MonoBehaviour
{
    public GameObject[] itemsToSpawn;
    public float spawnRadius = 10.0f;
    public int maxItems = 10;
    public float spawnInterval = 1.0f;

    private float _timeSinceLastSpawn = 0.0f;

    void Update()
    {
        // Увеличить время с момента последнего появления
        _timeSinceLastSpawn += Time.deltaTime;

        // Если пришло время создать новый элемент
        if (_timeSinceLastSpawn >= spawnInterval)
        {
            // Сбросить время с момента последнего появления
            _timeSinceLastSpawn = 0.0f;

            // Получить случайную позицию в пределах радиуса появления
            Vector3 randomPosition = transform.position + new Vector3(UnityEngine.Random.insideUnitSphere.x, 0.0f, UnityEngine.Random.insideUnitSphere.z) * spawnRadius;

            // Создать новый элемент в этой позиции
            GameObject item = Instantiate(itemsToSpawn[UnityEngine.Random.Range(0, itemsToSpawn.Length)], randomPosition, Quaternion.identity);
        }
    }
}