using UnityEngine;

public class CollectableItem : Interactable
{
    public NoteData noteData; 
    public GameObject particle;
    public AudioClip colllectedSound;

    protected override void Interact()
    {
        Debug.Log("Collectable item interacted with: " + gameObject.name);

        // Play particle effect
        if (particle != null)
        {
            Instantiate(particle, transform.position, Quaternion.identity);
        }
        // Play collection sound
        if (colllectedSound != null)
        {
            AudioSource.PlayClipAtPoint(colllectedSound, transform.position);
        }
        // Add the note data to the player's inventory or collection
        NoteInventory.Instance.AddNote(this);

        // Disable the collectable item
        gameObject.SetActive(false); // Disable instead of destroy to allow reactivation if need
    }

}