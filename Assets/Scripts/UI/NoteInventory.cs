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
            return;
        }

        collectedNotes.Add(note);
        onNoteCollected?.Invoke(note.noteData);
    }
}