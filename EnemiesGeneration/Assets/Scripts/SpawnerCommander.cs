using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCommander : MonoBehaviour
{
    [SerializeField] List<Spawner> _spawners;

    private float _delay = 2;

    private void Start()
    {
        StartCoroutine(AssignSpawner());
    }

    private IEnumerator AssignSpawner()
    {
        while (true)
        {
            var wait = new WaitForSeconds(_delay);

            if (_spawners.Count > 0)
            {
                int randomIndex = Random.Range(0, _spawners.Count);
                _spawners[randomIndex].SpawnEnemy();
            }

            yield return wait;
        }
    }
}
