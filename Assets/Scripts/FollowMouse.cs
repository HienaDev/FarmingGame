using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{


    private Vector2 lookDirection;
    private float lookAngle;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AimMethod();
    }

    private void AimMethod()
    {
        lookDirection = (Input.mousePosition);
        lookDirection.x /= 2;
        lookDirection.y /= 2;

        lookDirection.x -= 320;
        lookDirection.y -= 180;

        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;


        gameObject.transform.rotation = Quaternion.Euler(0, 0, lookAngle);
    }
}
