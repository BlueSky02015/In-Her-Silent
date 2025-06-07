using UnityEngine;

public class InteractDoor2 : Interactable
{
    [Header("Door Settings")]
    [SerializeField] private bool isOpen;

    [Header("Audio")]
    [SerializeField] private AudioClip doorOpenSound;
    [SerializeField] private AudioClip doorCloseSound;
    [SerializeField] private AudioClip doorLockedSound;

    private AudioSource audioSource;
    private Animator animator;
    private LockedDoor2 lockedDoor2;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        lockedDoor2 = GetComponent<LockedDoor2>();

        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    protected override void Interact()
    {
        // Check if door is locked first
        if (lockedDoor2 != null && lockedDoor2.IsLocked)
        {
            //Set the dialogue message only if locked
            dialogueMessage = "This one also lock? \n there must be a missing note i haven't find";
            audioSource.PlayOneShot(doorLockedSound);
            lockedDoor2.TryUnlock(); 
            return;
        }
        else
        {
            // Clear the dialogue message if unlocked
            dialogueMessage = string.Empty;
        }

        // Toggle door state
        isOpen = !isOpen;

        // Play appropriate sound
        if (audioSource != null)
        {
            var clip = isOpen ? doorOpenSound : doorCloseSound;
            if (clip != null) audioSource.PlayOneShot(clip);
        }

        // Trigger animation
        if (animator != null)
        {
            animator.SetBool("IsOpen", isOpen);
        }
    }

    public void SetInteractable(bool isInteractable)
    {
        if (animator != null)
        {
            animator.enabled = isInteractable;
        }
    }
}