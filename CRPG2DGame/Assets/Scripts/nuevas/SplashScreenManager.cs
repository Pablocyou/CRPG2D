using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreenManager : MonoBehaviour
{
    //public AudioClip splashTheme;
    public float waitTime = 10f;
    private float startedAt;
    private void Start()
    {
        //if (splashTheme != null) GameManager.Instance.audioManager.PlayMusic(splashTheme);
        startedAt = Time.time;
    }
    void Update()
    {
        if (Input.anyKeyDown || Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) ||
        Time.time - startedAt > waitTime)
        {
            Done();
        }
    }
    private void Done()
    {
        GameManager.Instance.GoToNextLevel(0);
        Destroy(gameObject);
    }

}
