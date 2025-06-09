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
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        
        if (bg_music != null)
        {
            main_channel.PlayOneShot(bg_music);
        }
        else
        {
            return;
        }
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
