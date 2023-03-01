using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyEvents : MonoBehaviour
{
    public GameObject jumpscare;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
        }
    }

    public void OnTriggerEnter(Collider collision)
    {


        if (collision.gameObject.tag == "Enemy")
        {
            //jumpscare.SetActive(true);
            //this.gameObject.SetActive(false);
        }

        else if (collision.gameObject.tag == "Exit")
        {
            //SceneManager.LoadScene("WinScreen", LoadSceneMode.Single);
        }
    }
}