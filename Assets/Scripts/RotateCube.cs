using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    [SerializeField] private Transform _cube;
    [SerializeField] private float _speed;

    private void Update()
    {
        _cube.transform.Rotate(new Vector3(0, 1, 0) * _speed * Time.deltaTime);
    }
}
