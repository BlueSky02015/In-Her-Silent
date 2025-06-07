using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI promptText;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private Image HandImage;
    private Coroutine typingCoroutine;
    private Coroutine clearCoroutine;


    public void UpdateText(string textMassage) => promptText.text = textMassage;

    public void showHandImage() => HandImage.enabled = true;

    public void hideHandImage() => HandImage.enabled = false;

    public void UpdateDialogueText(string dialogueMessage)
    {
        // Stop any ongoing typing or clearing coroutines
        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine);
        }
        if (clearCoroutine != null)
        {
            StopCoroutine(clearCoroutine);
        }

        // Start typing the new message
        typingCoroutine = StartCoroutine(TypeSentence(dialogueMessage));
    }

    private IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.05f); // Adjust typing speed here
        }

        // After finishing typing, wait 2 seconds then clear
        clearCoroutine = StartCoroutine(ClearAfterDelay(2f));
    }

    private IEnumerator ClearAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        dialogueText.text = string.Empty;
    }


}