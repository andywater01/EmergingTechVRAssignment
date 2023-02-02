using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkHandRotation : MonoBehaviour
{
    public GameObject heartRateText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (this.transform.rotation.z <= 40 && this.transform.rotation.y > 30)
        {
            heartRateText.SetActive(true);

        }
        else
        {
            heartRateText.SetActive(false);
        }
    }
}
