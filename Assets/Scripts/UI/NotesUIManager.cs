using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NoteUIManager : MonoBehaviour
{
    public GameObject notePanel; 
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI contentText;
    public Image noteImage;
    public Button nextButton; // For cycling through notes
    public Button prevButton;

    private int _currentNoteIndex = 0;

    private void Start()
    {
        notePanel.SetActive(false); // Hide the note panel initially
        NoteInventory.Instance.onNoteCollected += ShowLatestNote;

        // Set up button listeners
        nextButton.onClick.AddListener(ShowNextNote);
        prevButton.onClick.AddListener(ShowPreviousNote);
    }

    // Show the most recently collected note
    private void ShowLatestNote(NoteData _)
    {
        if (NoteInventory.Instance.collectedNotes.Count == 0) return;

        _currentNoteIndex = NoteInventory.Instance.collectedNotes.Count - 1;
        UpdateNoteUI();
        notePanel.SetActive(true); 
    }

    // Override UI based on current index
    private void UpdateNoteUI()
    {
        if (_currentNoteIndex < 0 || _currentNoteIndex >= NoteInventory.Instance.collectedNotes.Count)
            return;

        NoteData note = NoteInventory.Instance.collectedNotes[_currentNoteIndex].noteData;
        titleText.text = note.title;
        contentText.text = note.content;

        if (note.noteImage != null)
            noteImage.sprite = note.noteImage;
    }

    public void ShowNextNote()
    {
        if (_currentNoteIndex < NoteInventory.Instance.collectedNotes.Count - 1)
        {
            _currentNoteIndex++;
            UpdateNoteUI();
        }
    }

    public void ShowPreviousNote()
    {
        if (_currentNoteIndex > 0)
        {
            _currentNoteIndex--;
            UpdateNoteUI();
        }
    }
}