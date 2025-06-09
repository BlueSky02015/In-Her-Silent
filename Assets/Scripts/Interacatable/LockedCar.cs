using UnityEngine;

public class LockedCar : MonoBehaviour
{
    [Header("Note Settings")]
    public bool requiresNotes = true;
    private int requiredNotesCount = 4;

    [Header("Car State")]
    [SerializeField]
    private bool isLocked = true;
    private InteractableCar interactableCar;

    void Awake()
    {
        interactableCar = GetComponent<InteractableCar>();
        UpdateCarLockState();
    }

    // Called when trying to interact with the door
    public void TryUnlock()
    {
        if (!isLocked) return;

        if (!requiresNotes)
        {
            UnlockCar();
            return;
        }

        // Check if NoteInventory exists and has enough notes
        if (NoteInventory.Instance != null)
        {
            int currentNotes = NoteInventory.Instance.collectedNotes.Count;
            if (currentNotes >= requiredNotesCount)
            {
                UnlockCar();
            }
        }
    }

    private void UnlockCar()
    {
        isLocked = false;
        UpdateCarLockState();
        if (interactableCar != null) interactableCar.dialogueMessage = string.Empty;
    }

    private void UpdateCarLockState()
    {
        if (interactableCar != null) interactableCar.SetInteractable(!isLocked);
    }

    public bool IsLocked => isLocked;
}
