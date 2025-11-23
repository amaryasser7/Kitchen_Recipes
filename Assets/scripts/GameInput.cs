using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{

    public event EventHandler OnInteractAction;
    private PlayerInputActions playerInputActions;


    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();

        playerInputActions.Player.Interact.performed += Interact_performed;
        // playerInputActions.Player.InteractAlternate.performed += InteractAlternate_Performed;
    }

    

    private void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnInteractAction?.Invoke(this, EventArgs.Empty);
    }

    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = playerInputActions.Player.move.ReadValue<Vector2>();
        inputVector = inputVector.normalized;

        return inputVector;
    }
}
