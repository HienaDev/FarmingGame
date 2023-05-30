using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] private Transform target;

    [SerializeField] private float speed;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (target != null)
        { 
            Vector3 targetPosition = target.position;
            targetPosition.z = transform.position.z;

            Vector3 error = targetPosition - transform.position;

            //transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            transform.position = transform.position + error * Mathf.Min(Time.fixedDeltaTime / speed, 1);
        }

    }
}
