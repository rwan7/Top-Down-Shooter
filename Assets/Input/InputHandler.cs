using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "Input Handler", menuName = "Input Handler")]

public class InputHandler : ScriptableObject, CustomInput.IGameplayActions
{
    private CustomInput input;

    public UnityAction<Vector2> OnSetDirectionAction;

    private void OnEnable()
    {
        if (input == null)
            input = new CustomInput();

        input.Gameplay.SetCallbacks(this);

        input.Gameplay.Enable();
    }

    private void OnDisable()
    {
        input.Gameplay.Disable();
    }

    public void OnSetDirection(InputAction.CallbackContext context)
    {
        Debug.Log("Set Direction" + context.ReadValue<Vector2>() + " " + context.phase);

        if (context.phase == InputActionPhase.Performed || context.phase == InputActionPhase.Canceled)
        {
            OnSetDirectionAction?.Invoke(context.ReadValue<Vector2>());
        }
    }
}
