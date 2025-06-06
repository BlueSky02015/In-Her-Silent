using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    private PlayerInput playerInput;
    public PlayerInput.UIActions uiActions;
    public InputManager inputManager;


    [Header("Panel")]
    public GameObject GameOverScreen;
    public GameObject GamePauseScreen;
    public GameObject GameCreditScreen;
    public GameObject NotePanel;
    public bool isOver, isPlaying, isPause, isInCredit;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Awake()
    {
        HandleSingleton();

        if (instance == this)
        {
            InitializeGameState();
            InitializeInput();
        }
    }

    private void InitializeInput()
    {
        playerInput = new PlayerInput();
        uiActions = playerInput.UI;
    }


    private void InitializeGameState()
    {
        isPlaying = true;
        isOver = false;
        isPause = false;
        isInCredit = false;
        GameCreditScreen.SetActive(false);
        GamePauseScreen.SetActive(false);
        GameOverScreen.SetActive(false);
        NotePanel.SetActive(false);
    }

    private void HandleSingleton()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        uiActions.Enable();
    }

    private void OnDisable()
    {
        uiActions.Disable();
    }
    void Update()
    {
        HandleInput();
        HandleCursor();
    }

    void HandleCursor()
    {
        if (isPlaying)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    private void HandleInput()
    {

        if (uiActions.Escape.triggered)
        {
            HandleEscapeKey();
        }

        if (uiActions.Space.triggered && isOver)
        {
            RestartGame();
        }

    }

    private void HandleEscapeKey()
    {
        switch (true)
        {
            case bool _ when isPlaying:
                PauseGame();
                break;

            case bool _ when isPause && !isInCredit:
                ResumeGame();
                break;

            case bool _ when isInCredit:
                HideCreditScreen();
                break;

            case bool _ when isOver:
                ExitGame();
                break;
        }
    }

    public void GameOver()
    {
        isOver = true;
        isPause = false;
        isPlaying = false;
        GameOverScreen.SetActive(true);
    }

    private void PauseGame()
    {
        GamePauseScreen.SetActive(true);
        NotePanel.SetActive(true);
        isPause = true;
        isPlaying = false;
        Time.timeScale = 0;
    }

    private void ResumeGame()
    {
        GamePauseScreen.SetActive(false);
        NotePanel.SetActive(false);
        isPause = false;
        isPlaying = true;
        Time.timeScale = 1;
    }

    public void ShowCreditScreen()
    {
        GameCreditScreen.SetActive(true);
        isInCredit = true;
    }

    private void HideCreditScreen()
    {
        GameCreditScreen.SetActive(false);
        GamePauseScreen.SetActive(true);
        isInCredit = false;
    }

    public void RestartGame()
    {
        GameOverScreen.SetActive(false);
        Time.timeScale = 1;
        StartCoroutine(RestartRoutine());
    }

    private IEnumerator RestartRoutine()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(currentSceneName);

        while (!asyncLoad.isDone)
            yield return null;

        isOver = false;
        isPlaying = true;
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else 
        Application.Quit();
#endif
    }

    public void ExitGameFromPauseScreen()
    {
        ExitGame();
    }
}