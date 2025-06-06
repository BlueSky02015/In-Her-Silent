using UnityEngine;

public class InteractDoor : Interactable
{
    [Header("Door Settings")]
    [SerializeField] private bool isOpen;
    
    [Header("Audio")]
    [SerializeField] private AudioClip doorOpenSound;
    [SerializeField] private AudioClip doorCloseSound;
    [SerializeField] private AudioClip doorLockedSound;
    
    private AudioSource audioSource;
    private Animator animator;
    private LockedDoor lockedDoor;
    
    private void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        lockedDoor = GetComponent<LockedDoor>();
        
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    protected override void Interact()
    {
        // Check if door is locked first
        if (lockedDoor != null && lockedDoor.IsLocked)
        {
            if (doorLockedSound != null)
            {
                audioSource.PlayOneShot(doorLockedSound);
            }
            return;
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