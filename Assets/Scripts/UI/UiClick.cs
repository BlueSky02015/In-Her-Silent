using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEditor.EventSystems;
using System;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class UiClick : MonoBehaviour
{
    public GameObject uiCanvas;
    [SerializeField] private GraphicRaycaster graphicRaycaster;

    PointerEventData pointerEventData;
    List<RaycastResult> raycastResults;


    private void Start()
    {
        graphicRaycaster = uiCanvas.GetComponent<GraphicRaycaster>();
        pointerEventData = new PointerEventData(EventSystem.current);
        raycastResults = new List<RaycastResult>();
    }
    private void Update() {
        if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            GetUIElementUnderPointer();
        }
    }

    private void GetUIElementUnderPointer()
    {
        pointerEventData.position = Mouse.current.position.ReadValue();
        raycastResults.Clear();
        graphicRaycaster.Raycast(pointerEventData, raycastResults);

        if (raycastResults.Count > 0)
        {
            foreach (var result in raycastResults)
            {
                Debug.Log($"UI Element Clicked: {result.gameObject.name} at position {result.screenPosition}");
            }
        }
        else
        {
            Debug.Log("No UI elements clicked");
        }
    }
}