using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScale : MonoBehaviour
{
   [SerializeField] private GameObject _sphere;
   [SerializeField] private float _speed;
   [SerializeField] private Vector3 _scale;
   private Vector3 startScale;
   private bool isGrowing = true;
   

    private void Start()
    {
        startScale = transform.localScale;
    }
    private void Update()
    {
        Vector3 currentScale = transform.localScale;

        if (isGrowing)
        {
            currentScale += Vector3.one * _speed * Time.deltaTime;

            if(Vector3.Distance(currentScale, _scale) < 0.01f)
                isGrowing = false;
        }
        else
        {
            currentScale -= Vector3.one * _speed * Time.deltaTime;

            if(Vector3.Distance(currentScale, startScale) < 0.01f)
                isGrowing = true;
        }

        transform.localScale = currentScale;
    }
}
