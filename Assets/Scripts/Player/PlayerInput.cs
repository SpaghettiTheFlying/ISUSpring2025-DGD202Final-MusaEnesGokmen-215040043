using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerMover))]
public class PlayerInput : MonoBehaviour
{
    private PlayerInputActions inputActions;
    private PlayerMover mover;

    void Awake()
    {
        inputActions = new PlayerInputActions();
        mover = GetComponent<PlayerMover>();
    }

    void OnEnable()
    {
        inputActions.Enable();
    }

    void OnDisable()
    {
        inputActions.Disable();
    }

    void Update()
    {
        Vector2 moveInput = inputActions.Player.Move.ReadValue<Vector2>();
        mover.Move(moveInput);
    }
}
