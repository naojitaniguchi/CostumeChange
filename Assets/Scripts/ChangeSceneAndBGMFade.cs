using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneAndBGMFade : MonoBehaviour
{
    public GameObject bgm;
    public float fadeTime;
    public string nextScene;
    bool fadeStart = false;
    float timeRmain;

    // Start is called before the first frame update
    void Start()
    {
        timeRmain = fadeTime;
    }

    // Update is called once per frame
    void Update()
    {
        if ( fadeStart)
        {
            timeRmain -= Time.deltaTime;
            float volume = timeRmain / fadeTime;

            bgm.GetComponent<AudioSource>().volume = volume;

            if ( timeRmain < 0.0f)
            {
                SceneManager.LoadScene(nextScene);
            }
        }
    }

    public void ChangeStart()
    {
        fadeStart = true;
    }

}
