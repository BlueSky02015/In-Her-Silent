using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    [Header("Key Settings")]
    public bool requiresKey = true;
    
    [Header("Door State")]
    [SerializeField] 
    private bool isLocked = true;
    private InteractDoor interactDoor;

    [Header("Audio")]
    [SerializeField] 
    private AudioClip unlockSound;
    
    private AudioSource audioSource;

    void Awake()
    {
        interactDoor = GetComponent<InteractDoor>();
        audioSource = GetComponent<AudioSource>();
        
        // Ensure we have an AudioSource
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    
        UpdateDoorLockState();
    }


    public void TryUnlock(bool hasKey)
    {
        if (!isLocked) return; // Already unlocked
        
        if (!requiresKey)
        {
            UnlockDoor();
            return;
        }

        if (hasKey)
        {
            UnlockDoor();
            if (unlockSound != null)
            {
                audioSource.PlayOneShot(unlockSound);
            }
        }
        else
        {
            Debug.Log("Door is locked - you need the right key!");
        }
    }

    // Unlocks the door
    private void UnlockDoor()
    {
        isLocked = false;
        UpdateDoorLockState();
        Debug.Log("Door unlocked!");
    }

    // Updates the interactable state based on lock status
    private void UpdateDoorLockState()
    {
        if (interactDoor != null)
        {
            interactDoor.SetInteractable(!isLocked);
        }
    }

    // Public property to check if door is locked
    public bool IsLocked => isLocked;
}