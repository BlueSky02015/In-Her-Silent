using UnityEngine;

[CreateAssetMenu(fileName = "NoteData", menuName = "Inventory/NoteData")]
public class NoteData : ScriptableObject
{
    public string noteID;  // Unique identifier for each note
    public string title;   // Note title to display in UI
    [TextArea(3, 10)]
    public string content; // The actual note content
    public int collectionOrder; // The intended order for collection
    public Sprite noteImage; // Optional image to display with the note
}