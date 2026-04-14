using UnityEngine;

public class CapsuleScale : MonoBehaviour
{
   [SerializeField] private float _speed;
   [SerializeField] private Vector3 _scale;
  
    private void Update()
    {       
            Vector3 currentScale = transform.localScale;
        
            transform.localScale  = Vector3.MoveTowards(currentScale, _scale, _speed * Time.deltaTime);
    }
}
