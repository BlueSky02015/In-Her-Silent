using UnityEngine;

public class LockedDoor2 : MonoBehaviour
{
    [Header("Note Settings")]
    public bool requiresNotes = true;
    public int requiredNotesCount = 2;

    [Header("Door State")]
    [SerializeField]
    private bool isLocked = true;
    private InteractDoor2 interactDoor2;

    [Header("Audio")]
    [SerializeField]
    private AudioClip unlockSound;

    private AudioSource audioSource;

    void Awake()
    {
        interactDoor2 = GetComponent<InteractDoor2>();
        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        UpdateDoorLockState();
    }

    // Called when trying to interact with the door
    public void TryUnlock()
    {
        if (!isLocked) return;

        if (!requiresNotes)
        {
            UnlockDoor();
            return;
        }

        // Check if NoteInventory exists and has enough notes
        if (NoteInventory.Instance != null)
        {
            int currentNotes = NoteInventory.Instance.collectedNotes.Count;
            if (currentNotes >= requiredNotesCount)
            {
                UnlockDoor();
                if (unlockSound != null) audioSource.PlayOneShot(unlockSound);
            }
        }
    }

    private void UnlockDoor()
    {
        isLocked = false;
        UpdateDoorLockState();
        if (interactDoor2 != null) interactDoor2.dialogueMessage = string.Empty;
    }

    private void UpdateDoorLockState()
    {
        if (interactDoor2 != null) interactDoor2.SetInteractable(!isLocked);
    }

    public bool IsLocked => isLocked;
}
