using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] Enemy _enemyPrefab;

    private float _maxRandomRange = 10f;
    private float _minRandomRange = -10f;

    public void SpawnEnemy()
    {
        Enemy spawnedEnemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
        GiveDirectionEnemy(spawnedEnemy);
    }

    private void GiveDirectionEnemy(Enemy enemy)
    {
        float directionX = Random.Range(_minRandomRange, _maxRandomRange + 1);
        float directionZ = Random.Range(_minRandomRange, _maxRandomRange + 1);
        Vector3 randomDirection = new Vector3 (directionX, 0, directionZ);

        enemy.TakeDirection(randomDirection.normalized);
    }
}
