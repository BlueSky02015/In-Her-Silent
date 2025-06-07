using UnityEngine;

public class CollectableItem : Interactable
{
    public NoteData noteData; 
    public AudioClip colllectedSound;

    protected override void Interact()
    {
        // Play sound
        if (colllectedSound != null)
        {
            AudioSource.PlayClipAtPoint(colllectedSound, transform.position);
        }
        // Add the note data to the player's inventory or collection
        NoteInventory.Instance.AddNote(this);

        // Disable the collectable item
        gameObject.SetActive(false); 
    }

}