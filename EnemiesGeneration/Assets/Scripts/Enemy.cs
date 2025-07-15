using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Enemy : MonoBehaviour
{
    private float _speed = 2f;
    private Rigidbody _rigidbody;
    private Vector3 _direction = Vector3.zero;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _rigidbody.MovePosition(_rigidbody.position + _direction * _speed * Time.deltaTime);
    }

    public void TakeDirection(Vector3 direction)
    {
        _direction = direction;
    }
}
