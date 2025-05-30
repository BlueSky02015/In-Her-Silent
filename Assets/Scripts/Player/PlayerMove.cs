using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private CharacterController controller;
    private Transform cameraTransform;

    private Vector3 playerVelocity;
    private bool isgrounded;
    private float gravity = -9.81f;
    private float speed = 5f;

    // Footstep variables
    private float footstepDelay = 0.4f; // Time between footsteps
    private float nextFootstepTime = 0f;
    private float minMovementSpeed = 0.1f; // Minimum speed to trigger footsteps

    [SerializeField] private AudioManager audioManager;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        cameraTransform = Camera.main.transform;
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void Update()
    {
        isgrounded = controller.isGrounded;
    }

    public void Movement(Vector2 input)
    {
        // Movement code remains the same
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;
        forward = forward.normalized;
        right = right.normalized;

        Vector3 move = (forward * input.y + right * input.x).normalized;
        controller.Move(move * speed * Time.deltaTime);
        
        // Play footsteps only when conditions are met
        if (isgrounded && controller.velocity.magnitude > minMovementSpeed)
        {
            PlayFootstep();
        }

        // Gravity code remains the same
        playerVelocity.y += gravity * Time.deltaTime;
        if (isgrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = -1f;
        }
        controller.Move(playerVelocity * Time.deltaTime);
    }
    
    private void PlayFootstep()
    {
        // Only play if cooldown has passed
        if (Time.time >= nextFootstepTime)
        {
            audioManager.playSFX(audioManager.PlayerFootStepSFX);
            nextFootstepTime = Time.time + footstepDelay;
        }
    }
}