using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartRate : MonoBehaviour
{
    public Text heartrate;
    //public Text testText;
    //public string baseHR;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Calibrate()
    {
        PlayerPrefs.SetInt("baseHR", int.Parse(heartrate.text));
        //print(PlayerPrefs.GetInt("baseHR".ToString()));
        //testText.text = (PlayerPrefs.GetInt("BaseHR").ToString());
    }
}
