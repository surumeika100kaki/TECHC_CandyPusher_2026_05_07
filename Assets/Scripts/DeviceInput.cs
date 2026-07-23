using UnityEngine;
using UnityEngine.InputSystem;

public class DeviceInput : MonoBehaviour
{
    //InputAction‚ğg—p‚µ‚Ä“ü—Í‚ğ‚Æ‚é
    private InputAction createCandyAction;
    private InputAction inputVector2Action;
    private CreateCandy createCandy;

    void Start()
    {
        //InputSystem‚É“o˜^‚³‚ê‚Ä‚¢‚éAction–¼hAttackh‚ğæ“¾‚µ‚Ä‚¢‚é
        createCandyAction = InputSystem.actions.FindAction("CreateCandy");
        inputVector2Action = InputSystem.actions.FindAction("ValueTest");
        createCandy = GetComponent<CreateCandy>();
    }

    void Update()
    {
        Debug.Log(inputVector2Action.ReadValue<Vector2>());
        //‚à‚µcreateCandyAction‚É“o˜^‚³‚ê‚Ä‚¢‚éƒ{ƒ^ƒ“‚ª‰Ÿ‚³‚ê‚½‚ç
        if (createCandyAction.WasPerformedThisFrame())
        {
            Debug.Log("ƒ{ƒ^ƒ“‚ª‰Ÿ‚³‚ê‚Ü‚µ‚½");
            createCandy.AddCandy();
            AudioManager.instance.SEPlay(0);
        }
    }
}
