using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/*
* XboxRemoteControl.cs
* TODO Add other button input handling
* TODO Generalise from depth perception app
*/

public class XboxRemoteControl : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    
    public bool buttonA;
    public bool buttonB;
    public bool dpad;

    private void Update()
    {
        buttonA = false;
        buttonB = false;
        dpad = false;
        
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
