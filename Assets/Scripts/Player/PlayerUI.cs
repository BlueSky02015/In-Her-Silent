using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI promptText;


    void Start()
    {

    }

    public void UpdateText(string textMassage)
    {
        promptText.text = textMassage;
    }
}