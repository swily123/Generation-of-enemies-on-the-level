using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float _speed = 20f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public IEnumerator GoToPoint(Transform target)
    {
        while (enabled)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            direction.y = 0;

            transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
            //transform.Translate(_speed * Time.deltaTime * Vector3.forward);
            _rigidbody.MovePosition(transform.position + direction * Time.deltaTime * _speed);

            yield return null;
        }
    }
}
