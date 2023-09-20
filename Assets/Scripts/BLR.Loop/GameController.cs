using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BLR.Loop;
using BLR.Player;
using UnityEngine.InputSystem;


namespace BLR.Loop 
{
    public class GameController : MonoBehaviour
    {
        [SerializeField]
        private InputManager inputManager;

        public InputManager InputManager => inputManager;
        private BaseState currentState;

        private void Awake()
        {
            ChangeState(new GameState());
            inputManager.BeforeInitializeInput();
        }

        void Start()
        {
           
        }
      
        void Update()
        {
            currentState?.Tick();
        }

        private void LateUpdate()
        {
            currentState?.LateTick();
        }

        private void FixedUpdate()
        {
            currentState?.FixedTick();
        }

        public void ChangeState(BaseState newState)
        {
            currentState?.Dispose();
            currentState = newState;
            currentState?.BeforeInitialize(this);
            currentState?.Initialize();
        }
    }
}

