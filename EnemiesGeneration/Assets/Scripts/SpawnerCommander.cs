using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCommander : MonoBehaviour
{
    [SerializeField] private List<Spawner> _spawners;

    private float _delay = 10;

    private void Start()
    {
        StartCoroutine(AssignSpawner());
    }

    private IEnumerator AssignSpawner()
    {
        while (enabled)
        {
            if (_spawners.Count > 0)
            {
                int randomIndex = Random.Range(0, _spawners.Count);
                _spawners[randomIndex].SpawnEnemy();
            }

            yield return new WaitForSeconds(_delay);
        }
    }
}
