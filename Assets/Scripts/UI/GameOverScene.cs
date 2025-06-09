using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour {
    
    string gameover = "OutroScene";

    public void GameOver()
    {
        SceneManager.LoadScene(gameover);
    }

}