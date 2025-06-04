using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI promptText;
    [SerializeField] private Image HandImage;

    public void UpdateText(string textMassage) => promptText.text = textMassage;

    public void showHandImage() => HandImage.enabled = true;
    
    public void hideHandImage() => HandImage.enabled = false;

}