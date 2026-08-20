using UnityEngine;
using UnityEngine.InputSystem;

public class DeviceInput : MonoBehaviour
{
    private InputAction createCandyAction;
    private InputAction inputVector2Action;
    private CreateCandy createCandy;

    void Start()
    {
        createCandyAction = InputSystem.actions.FindAction("CreateCandy");
        inputVector2Action = InputSystem.actions.FindAction("ValueTest");
        createCandy = GetComponent<CreateCandy>();
    }

    void Update()
    {
        Debug.Log(inputVector2Action.ReadValue<Vector2>());
        if (createCandyAction.WasPerformedThisFrame())
        {
            createCandy.DropCandy();
        }
    }
}
