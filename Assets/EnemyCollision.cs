using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollision : MonoBehaviour
{
    public GameObject jumpscare;
    public GameObject enemy;
    public AudioSource scream;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("EnemyCollision");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("EnemyCollision");
            jumpscare.SetActive(true);
            enemy.SetActive(false);
            scream.Play();
            StartCoroutine(pauseRestart());
        }

        else if (other.gameObject.tag == "Exit")
        {
            SceneManager.LoadScene("WinScreen", LoadSceneMode.Single);
        }
    }

    IEnumerator pauseRestart()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("FirstVRScene", LoadSceneMode.Single);
        
    }

}
