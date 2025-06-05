using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NoteUIManager : MonoBehaviour
{
    public GameObject notePanel; 
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI contentText;
    public Button nextButton;
    public Button prevButton;

    private int _currentNoteIndex = -1; 

    private void Start()
    {
        notePanel.SetActive(false);
        NoteInventory.Instance.onNoteCollected += ShowLatestNote;

        nextButton.onClick.AddListener(ShowNextNote);
        prevButton.onClick.AddListener(ShowPreviousNote);
    }

    private void ShowLatestNote(NoteData _)
    {
        if (NoteInventory.Instance.collectedNotes.Count == 0)
        {
            return;
        }

        // Set to last index and show
        _currentNoteIndex = NoteInventory.Instance.collectedNotes.Count - 1;
        UpdateNoteUI();
        notePanel.SetActive(true);
        
    }

    private void UpdateNoteUI()
    {
        if (_currentNoteIndex < 0 || _currentNoteIndex >= NoteInventory.Instance.collectedNotes.Count)
        {
            return;
        }

        var noteItem = NoteInventory.Instance.collectedNotes[_currentNoteIndex];
        if (noteItem == null || noteItem.noteData == null)
        {
            return;
        }

        NoteData note = noteItem.noteData;
        titleText.text = note.title;
        contentText.text = note.content;

        // Update button interactability
        prevButton.interactable = _currentNoteIndex > 0;
        nextButton.interactable = _currentNoteIndex < NoteInventory.Instance.collectedNotes.Count - 1;
    }

    public void ShowNextNote()
    {
        if (_currentNoteIndex < NoteInventory.Instance.collectedNotes.Count - 1)
        {
            _currentNoteIndex++;
            UpdateNoteUI();
            Debug.Log($"Showing next note. Current index: {_currentNoteIndex}");
        }
    }

    public void ShowPreviousNote()
    {
        if (_currentNoteIndex > 0)
        {
            _currentNoteIndex--;
            UpdateNoteUI();
            Debug.Log($"Showing previous note. Current index: {_currentNoteIndex}");
        }
    }
}