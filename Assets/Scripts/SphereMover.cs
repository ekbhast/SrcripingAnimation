using UnityEngine;

public class SphereMover : MonoBehaviour
{
    [SerializeField] private Transform _sphere;
    [SerializeField] private float _speed;

    private void Update()
    {
        _sphere.transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}
