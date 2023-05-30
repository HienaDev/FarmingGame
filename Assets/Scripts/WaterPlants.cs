using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPlants : MonoBehaviour
{

    [SerializeField]
    private GameObject hand;

    //[SerializeField]
    //private GameObject waterPoint2;

    //[SerializeField]
    //private GameObject waterPoint3;

    //[SerializeField]
    //private GameObject waterPoint4;

    //[SerializeField]
    //private GameObject waterPoint5;

    [SerializeField]
    private GameObject[] waterPoints;

    private List<LineRenderer> lines;


    // Start is called before the first frame update
    private void Start()
    {
        while(lines == null)
        { 
            foreach (GameObject point in waterPoints)
            {
                lines.Add(point.GetComponent<LineRenderer>());
            }
        }
    }
    // Update is called once per frame
    private void Update()
    {



        
        //RaycastHit2D hit = Physics2D.Linecast(gameObject.transform.position, lightSource.transform.position);

        //Debug.DrawLine(hand.transform.position, waterPoint1.transform.position);
        //Debug.DrawLine(gameObject.transform.position, waterPoint2.transform.position);
        //Debug.DrawLine(gameObject.transform.position, waterPoint3.transform.position);
        //Debug.DrawLine(gameObject.transform.position, waterPoint4.transform.position);
        //Debug.DrawLine(gameObject.transform.position, waterPoint5.transform.position);
    }
}
