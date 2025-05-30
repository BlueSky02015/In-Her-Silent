using UnityEngine;

public class Lantern : Interactable
{
    [SerializeField] private GameObject lanternLight;
    [SerializeField] private bool isOn;
    public Transform desiredPosition;
    private MeshCollider meshCollider;

    protected override void Interact()
    {
        isOn = !isOn;
        if (lanternLight != null)
        {
            lanternLight.SetActive(isOn); // Enable or disable the light
        }
    }
    void Start()
    {
        meshCollider = GetComponent<MeshCollider>();
    }
    void Update()
    {
        // when pick up the lantern, it should be in the disired position
        if (isOn)
        {
            if (meshCollider != null)
            {
                // Disable the collider when the lantern is picked up
                meshCollider.enabled = false;
            }
            transform.position = desiredPosition.position;
            transform.rotation = desiredPosition.rotation;
        }
    }

}