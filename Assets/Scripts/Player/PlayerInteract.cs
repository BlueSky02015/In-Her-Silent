using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteract : MonoBehaviour
{
    private new Camera camera;
    [SerializeField] private float interactDistance = 3f;
    [SerializeField] private LayerMask mask;
    private PlayerUI playerUI;
    private InputManager inputManager;

    private void Start()
    {
        camera = GetComponent<PlayerLook>().playerCamera;
        playerUI = GetComponent<PlayerUI>();
        inputManager = GetComponent<InputManager>();
    }
    void Update()
    {
        // Clear the prompt text each frame
        playerUI.UpdateText(string.Empty);

        // Cast a ray from the camera to check for interactable objects
        Ray ray = new Ray(camera.transform.position, camera.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * interactDistance, Color.red);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, interactDistance, mask))
        {
            Interactable interactable = hit.collider.GetComponent<Interactable>();
            if (interactable != null)
            {
                // Display the interaction prompt
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.Interact.triggered)
                {
                    // Call the base interaction method of the interactable object
                    interactable.BaseInteract();
                }
            }
        }
    }
}