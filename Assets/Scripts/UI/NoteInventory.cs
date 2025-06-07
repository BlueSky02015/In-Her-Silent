using System;
using System.Collections.Generic;
using UnityEngine;

public class NoteInventory : MonoBehaviour
{
    public static NoteInventory Instance;

    public List<CollectableItem> collectedNotes = new List<CollectableItem>();
    public System.Action<NoteData> onNoteCollected;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddNote(CollectableItem note)
    {
        if (note == null || note.noteData == null)
        {
            Debug.LogWarning("Tried to add a null note!");
            return;
        }

        collectedNotes.Add(note);
        Debug.Log($"Added note: {note.noteData.title}. Total notes: {collectedNotes.Count}");

        // Optional: Sort if needed
        collectedNotes.Sort((a, b) => a.noteData.collectionOrder.CompareTo(b.noteData.collectionOrder));

        onNoteCollected?.Invoke(note.noteData);
    }
}