using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerEffect : MonoBehaviour
{
    public Light lantern;

    public float timer = 0.0f;
    public float randomTime;

    public AudioSource buzzing;

    private void Start()
    {
        TimeRand();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= randomTime)
        {
            StartCoroutine(FlickerLight());
        }
        else if (timer > 4.5 && timer < 5f)
        {
            lantern.GetComponent<Light>().enabled = true;
        }
    }

    void TimeRand()
    {
        randomTime = Random.Range(8f, 25f);
    }


    IEnumerator FlickerLight()
    {
        buzzing.Play();
        lantern.GetComponent<Light>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        lantern.GetComponent<Light>().enabled = true;
        yield return new WaitForSeconds(0.5f);
        lantern.GetComponent<Light>().enabled = false;
        
        
        TimeRand();
        timer = 0.0f;
    }

    
}
