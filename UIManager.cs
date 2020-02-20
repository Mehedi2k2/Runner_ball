using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    void Start()
    {
       
    }

    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
        AudioManager.instance.PlayAudio(3);
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
        AudioManager.instance.PlayAudio(3);
        Time.timeScale = 1;
    }

    public void home()
    {
        SceneManager.LoadScene(0);
        AudioManager.instance.PlayAudio(3);
        Time.timeScale = 1;
    }

  
}
