using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncreaseWaterBar : MonoBehaviour
{

    public bool GetWatered { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GetWatered)
        {
            GetComponentInChildren<Image>().fillAmount += 0.01f;
            if (GetComponentInChildren<Image>().fillAmount >0.95f)
                GetComponentInChildren<Image>().fillAmount = 0;
        }
    }

    
}
