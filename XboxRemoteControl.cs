using UnityEngine;
using UnityEngine.InputSystem;

/*
* XboxRemoteControl.cs
* TODO Add other button input handling
* TODO Generalise from depth perception app
* TODO Comments and file summary
*/

public class XboxRemoteControl : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    
    private bool buttonA = false;
    private bool buttonB = false;
    private bool buttonX = false;
    private bool buttonY = false;
    private bool dpadUp = false;
    private bool dpadDown = false;
    private bool dpadLeft = false;
    private bool dpadRight = false;
    private bool rightButton = false;
    private bool leftButton = false;
    private bool rightTrigger = false;
    private bool leftTrigger = false;

    private void Start()
    {
        
    }

    private void Update()
    {    
        // Get the gamepad input
        var gamepad = Gamepad.current;
        if (gamepad == null)
        {
            return; // No gamepad connected
        }


        if (gameObject.GetComponent<MeshRenderer>().enabled)
        {
            // Get the left stick input for movement
            Vector2 move = gamepad.leftStick.ReadValue();
            
            // Apply movement to the object -- Fixed on x and y axes?
            Vector3 movement = new Vector3(0, 0, move.y) * moveSpeed * Time.deltaTime;
            transform.Translate(movement, Space.World);
        }
        
        // Handle 'A' and 'B' button press
        if (gamepad.buttonSouth.wasPressedThisFrame)
        {
            buttonA = true;
        }

        if (gamepad.buttonEast.wasPressedThisFrame)
        {
            buttonB = true;
        }

        if (gamepad.dpad.down.wasPressedThisFrame || gamepad.dpad.up.wasPressedThisFrame || 
            gamepad.dpad.left.wasPressedThisFrame || gamepad.dpad.right.wasPressedThisFrame)
        {
            dpad = true;
        }
    }
}
