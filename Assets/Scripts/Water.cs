using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Water : MonoBehaviour
{

    private LineRenderer line;

    [SerializeField]
    private GameObject hand;

    [SerializeField]
    private LayerMask plantMask;

    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3[] positions = { hand.transform.position, gameObject.transform.position };



        line.startWidth = 0f;
        line.endWidth = 0f;


        if (Input.GetMouseButton(0))
        {
            RaycastHit2D hit = Physics2D.Linecast(hand.transform.position, gameObject.transform.position, plantMask);

            if (hit.collider != null)
            { 
                hit.collider.GetComponent<IncreaseWaterBar>().GetWatered = true;
            }


            line.startWidth = 1f;
            line.endWidth = 0.2f;
        }

        line.SetPositions(positions);
    }
}
