using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    public InputSystem_Actions Inputs;
    public static Vector2 MoveInput = Vector2.zero;
    public static Action OnJump;
    public static Action OnDash;
    private void Awake()
    {
        Inputs = new();

    }
    private void OnEnable()
    {
        Inputs.Enable();
        Inputs.Player.Move.performed += OnMove;
        Inputs.Player.Move.canceled += OnMoveCancelled;
        Inputs.Player.Jump.performed += OnJumpInput;
       
        OnJump += SimpleSubscriber;
        OnJump += SimpleSubscriber2;
        OnJump += SimpleSubscriber3;
    }
    private void OnDisable()
    {
        Inputs.Player.Move.performed -= OnMove;
        Inputs.Player.Move.canceled -= OnMoveCancelled;

        Inputs.Disable();
    }
    private void OnMoveCancelled(InputAction.CallbackContext context)
    {
        MoveInput = Vector2.zero;
    }
    private void OnMove(InputAction.CallbackContext context)
    {
        MoveInput = context.ReadValue<Vector2>();
    }
    void Start()
    {

    }
    void Update()
    {

    }
    private void OnJumpInput(InputAction.CallbackContext context)
    {
        OnJump?.Invoke();
    }
    private void SimpleSubscriber()
    {
        Debug.Log("apretado");
    }
    private void SimpleSubscriber2()
    {
        Debug.Log("apretado");
    }
    private void SimpleSubscriber3()
    {
        Debug.Log("apretado");
    }



}
