using UnityEngine;

public class CubeRotateSalceMover : MonoBehaviour
{
    [SerializeField] private float _speedMoving;
    [SerializeField] private float _speedScaling;
    [SerializeField] private float _speedRotate;
    [SerializeField] private Vector3 _scale;

    private void Update()
    {
        transform.Translate(Vector3.forward * _speedMoving * Time.deltaTime);
        Vector3 currentScale = transform.localScale;
        currentScale = Vector3.MoveTowards(currentScale, _scale, _speedScaling * Time.deltaTime);
        transform.localScale = currentScale;
        transform.Rotate(new Vector3(0, 1, 0) * _speedRotate * Time.deltaTime);
    }

}
