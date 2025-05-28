using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    private Transform cameraTransform;

    private Vector3 playerVelocity;
    private bool isgrounded;
    private float gravity = -9.81f;
    private float speed = 5f;

    void Start()
    {
        
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        controller = GetComponent<CharacterController>();
        cameraTransform = Camera.main.transform;

    }

    void Update()
    {
        isgrounded = controller.isGrounded;
    }

    public void Movement(Vector2 input)
    {
        // Get camera's forward and right vectors, ignoring vertical component
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;
        forward.y = 0;
        right.y = 0;
        forward.Normalize();
        right.Normalize();

        // Calculate movement direction relative to camera
        Vector3 move = (forward * input.y + right * input.x).normalized;
        controller.Move(move * speed * Time.deltaTime);

        // Apply gravity
        playerVelocity.y += gravity * Time.deltaTime;
        if (isgrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = -1f;
        }
        controller.Move(playerVelocity * Time.deltaTime);
    }
}