using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayAnim : MonoBehaviour
{
    public float timer = 0.0f;
    public float playTime = 1.0f;
    public Animation beat;
    public AudioSource beatSound;

    public int heartRate;
    public Text heartrateText;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ChangeTime", 6.0f, 0.1f);
    }

    public void ChangeTime()
    {
        heartRate = int.Parse(heartrateText.text);
        playTime = 60.0f / heartRate;
    }

    // Update is called once per frame
    void Update()
    {


        timer += Time.deltaTime;
        if (timer >= playTime)
        {
            beat.Play();
            beatSound.Play();
            timer = 0.0f;
        }
    }
}