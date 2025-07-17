using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private List<GameObject> _waypoints = new List<GameObject>();

    public void SpawnEnemy()
    {
        Enemy spawnedEnemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
        StartCoroutine(GoByWaypoints(spawnedEnemy, _waypoints));
    }

    private IEnumerator GoByWaypoints(Enemy enemy, List<GameObject> waypoints)
    {
        for (int i = 0; i < waypoints.Count; i++)
        {
            Transform point = waypoints[i].transform;
            Coroutine coroutine = StartCoroutine(enemy.GoToPoint(point));

            yield return new WaitUntil(() => Vector3.Distance(enemy.transform.position, point.position) <= 0.1f);
            StopCoroutine(coroutine);
        }
    }
}
