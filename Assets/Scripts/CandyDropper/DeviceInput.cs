using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

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
        // UIの上にマウスがある場合は処理しない
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if (createCandyAction.WasPerformedThisFrame())
        {
            createCandy.DropCandy();
        }
    }
}
