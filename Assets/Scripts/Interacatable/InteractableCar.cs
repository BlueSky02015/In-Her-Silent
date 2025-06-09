using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractableCar : Interactable
{
    [Header("Audio")]
    [SerializeField] private AudioClip LockedSound;


    private AudioSource audioSource;
    private LockedCar lockedCar;
    private GameOverScene gameOverScene;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        lockedCar = GetComponent<LockedCar>();
        gameOverScene = GetComponent<GameOverScene>();

        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    protected override void Interact()
    {
        lockedCar.TryUnlock();

        // Check if is locked first
        if (lockedCar != null && lockedCar.IsLocked)
        {
            //Set the dialogue message only if locked
            dialogueMessage = "Maybe i should check grandmas house first";
            audioSource.PlayOneShot(LockedSound);
            return;
        }
        else
        {
            // Clear the dialogue message if unlocked
            dialogueMessage = string.Empty;

            // Car is unlocked
            if (gameOverScene != null)
            {
                gameOverScene.GameOver();
            }

        }
    }

    public void SetInteractable(bool isInteractable)
    {
        if (gameOverScene != null)
        {
            gameOverScene.enabled = isInteractable;
        }
    }
}