using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;

public class UIDebugger : MonoBehaviour
{
    [Header("Settings")]
    public bool logAllUIInteractions = true;
    public bool highlightPressedElements = true;
    public Color highlightColor = Color.yellow;
    public float highlightDuration = 0.5f;

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame ||
            (Touchscreen.current != null && Touchscreen.current.primaryTouch.press.wasPressedThisFrame))
        {
            DebugUIElementsUnderPointer();
        }
    }

    private void DebugUIElementsUnderPointer()
    {
        PointerEventData eventData = new PointerEventData(EventSystem.current);
        eventData.position = Pointer.current.position.ReadValue();

        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, results);

        if (results.Count > 0)
        {
            foreach (var result in results)
            {
                if (logAllUIInteractions)
                {
                    string logMessage = $"UI Press: {result.gameObject.name} | " +
                                      $"Layer: {LayerMask.LayerToName(result.gameObject.layer)} | " +
                                      $"Tag: {result.gameObject.tag} | " +
                                      $"Position: {result.screenPosition}";

                    Debug.Log(logMessage, result.gameObject);   
                }

                if (highlightPressedElements)
                {
                    StartCoroutine(HighlightElement(result.gameObject));
                }
            }
        }
        else
        {
            Debug.Log("No UI elements pressed");
        }
    }

    private IEnumerator HighlightElement(GameObject uiElement)
    {
        var images = uiElement.GetComponentsInChildren<Image>();
        Dictionary<Image, Color> originalColors = new Dictionary<Image, Color>();

        // Store original colors
        foreach (var image in images)
        {
            originalColors[image] = image.color;
            image.color = highlightColor;
        }

        yield return new WaitForSeconds(highlightDuration);

        // Restore original colors
        foreach (var image in images)
        {
            if (image != null && originalColors.ContainsKey(image))
            {
                image.color = originalColors[image];
            }
        }
    }
}