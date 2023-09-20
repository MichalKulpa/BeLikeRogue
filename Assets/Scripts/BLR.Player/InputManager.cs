using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using BLR.Gun;

namespace BLR.Player
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField]
        private PlayerMotor playerMotor;
        [SerializeField]
        private PlayerLook playerLook;
        [SerializeField]
        private Pistol pistol;

        private InputSystem inputSystem;

        public InputSystem.InGameActions inGame;
        

        public void BeforeInitializeInput()
        {
            inputSystem = new InputSystem();
            inGame = inputSystem.InGame;
            inGame.Movement.performed += ctx => playerMotor.ProcessMove(ctx.ReadValue<Vector2>());
            inGame.Look.performed += ctx => playerLook.ProcessLook(ctx.ReadValue<Vector2>());
            inGame.Dodge.performed += ctx => playerMotor.ProcessDodge();
            inGame.Shoot.performed += ctx => pistol.Shoot();
            inGame.Reload.performed += ctx => pistol.Reload();
                      
        }
        public void TickInput()
        {
            pistol.DisplayAmmo();
        }
        public void FixedTickInput()
        {
            playerMotor.ProcessMove(inGame.Movement.ReadValue<Vector2>());
        }
        public void LateTickInput()
        {
            playerLook.ProcessLook(inGame.Look.ReadValue<Vector2>());
        }
        private void OnDisable()
        {
            inGame.Disable();
        }
        private void OnEnable()
        {
            inGame.Enable();
        }
    }
}

