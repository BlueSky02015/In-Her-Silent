using UnityEngine;
using UnityEngine.InputSystem;
public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    public PlayerInput.PlayerActions playerActions;
    private PlayerMove playerMotor;
    private PlayerLook playerLook;

    void Awake()
    {
        playerInput = new PlayerInput();
        playerActions = playerInput.Player;
        playerMotor = GetComponent<PlayerMove>();
        playerLook = GetComponent<PlayerLook>();

    }

    void FixedUpdate()
    {
        // Call the Move method on PlayerMotor with the input from PlayerActions
        playerMotor.Movement(playerActions.Move.ReadValue<Vector2>());
    }

    void LateUpdate()
    {
        // Call the Look method on PlayerLook with the input from PlayerActions
        playerLook.Look(playerActions.Look.ReadValue<Vector2>());

    }

    // Enable and disable the input actions when the script is enabled or disabled
    private void OnEnable()
    {
        playerActions.Enable();
    }
    private void OnDisable()
    {
        playerActions.Disable();
    }
}
