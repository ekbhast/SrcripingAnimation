using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMover : MonoBehaviour
{
    [SerializeField] private Transform _sphere;
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _direction;

    private void Update()
    {
        _sphere.transform.Translate(_direction * _speed * Time.deltaTime);
    }
}
