using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    string newGameScene = "MainScene";
    public AudioClip bg_music;
    public AudioSource main_channel;
    
    void Start()
    {
        main_channel.PlayOneShot(bg_music);
    }
    public void StaerNewGame()
    {
        main_channel.Stop();
        SceneManager.LoadScene(newGameScene);
    }

    public void ExitApp()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else 
        Application.Quit();
#endif
    }
    
}
