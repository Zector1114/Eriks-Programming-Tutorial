using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager
{

    private static GameControls _gameControls;

    public static void Init(Player myPlayer)
    {
        _gameControls = new GameControls();

        _gameControls.Permanent.Enable();

        _gameControls.InGame.Movement.performed += watchWASD => 
        {
            myPlayer.SetMovementDirection(watchWASD.ReadValue<Vector3>());
        };

        _gameControls.InGame.Jump.performed += watchJump =>
        {
            myPlayer.JumpCheck(watchJump.ReadValue<float>());
        };
    }

    public static void SetGameControls()
    {
        _gameControls.InGame.Enable();
        _gameControls.UI.Disable();
    }

    public static void SetUIControls()
    {
        _gameControls.UI.Enable();
        _gameControls.InGame.Disable();
    }
}
