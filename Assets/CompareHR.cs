using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class CompareHR : MonoBehaviour
{
    public Text heartRate;
    public Text EnemySpeedText;
    public GameObject ghost;
    public float Enemyspeed;
    public Text baseHR;

    public void Awake()
    {
        Enemyspeed = ghost.GetComponent<NavMeshAgent>().speed;

        if (PlayerPrefs.HasKey("baseHR") == false)
        {
            PlayerPrefs.SetInt("baseHR", 85);
        }

        baseHR.text = "Base HR: " + (PlayerPrefs.GetInt("baseHR").ToString());
    }

    public void Start()
    {
        //heartRate = GameObject.Find("HeartRateText").GetComponent<Text>();
        InvokeRepeating("CheckHR", 6.0f, 1.0f);
    }

    public void Update()
    {
        ghost.GetComponent<NavMeshAgent>().speed = Enemyspeed;
        EnemySpeedText.text = "Enemy Speed: " + Enemyspeed.ToString() + "x";
    }

    public void CheckHR()
    {
        if (int.Parse(heartRate.text) >= (PlayerPrefs.GetInt("baseHR") + 2) && int.Parse(heartRate.text) < (PlayerPrefs.GetInt("baseHR") + 4))
        {
            Debug.Log(Enemyspeed.ToString());
            Debug.Log(PlayerPrefs.GetInt("baseHR").ToString());
            Debug.Log(heartRate.text + "\n");

            Enemyspeed = 1.2f;
        }
        else if (int.Parse(heartRate.text) >= (PlayerPrefs.GetInt("baseHR") + 4) && int.Parse(heartRate.text) < (PlayerPrefs.GetInt("baseHR") + 5))
        {
            Debug.Log(Enemyspeed.ToString());
            Debug.Log(PlayerPrefs.GetInt("baseHR").ToString());
            Debug.Log(heartRate.text + "\n");

            Enemyspeed = 1.5f;
        }
        else if (int.Parse(heartRate.text) >= (PlayerPrefs.GetInt("baseHR") + 5))
        {
            Debug.Log(Enemyspeed.ToString());
            Debug.Log(PlayerPrefs.GetInt("baseHR").ToString());
            Debug.Log(heartRate.text + "\n");

            Enemyspeed = 1.8f;
        }




        else if (int.Parse(heartRate.text) < PlayerPrefs.GetInt("baseHR") + 2 && int.Parse(heartRate.text) >= PlayerPrefs.GetInt("baseHR"))
        {
            Debug.Log("Heart Rate Not Increased");
            Debug.Log(PlayerPrefs.GetInt("baseHR").ToString());
            Debug.Log(heartRate.text + "\n");

            Enemyspeed = 1.0f;
        }
        else if (int.Parse(heartRate.text) < PlayerPrefs.GetInt("baseHR"))
        {
            Debug.Log("Heart Rate Decreased");
            Debug.Log(PlayerPrefs.GetInt("baseHR").ToString());
            Debug.Log(heartRate.text + "\n");

            Enemyspeed = 0.85f;
        }
    }
}
