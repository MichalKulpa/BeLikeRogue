// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/BLR.Player/InputSystem.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace BLR.Player
{
    public class @InputSystem : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputSystem()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystem"",
    ""maps"": [
        {
            ""name"": ""InGame"",
            ""id"": ""e589169b-2582-4cac-8420-3368f4f6858a"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""c79b06bb-efc8-4999-9d05-254539323308"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dodge"",
                    ""type"": ""Button"",
                    ""id"": ""533bed33-9ca5-4d55-aaf3-08962cbc44fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""a0e491db-6ee0-4d2e-a4da-d333b6736cd8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""b191f105-fbc8-496b-9291-49d19454b087"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""1be05868-4385-4817-ac3e-7db2a5678dd1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AlternativeShoot"",
                    ""type"": ""Button"",
                    ""id"": ""84a7e3de-2b02-4605-82fc-b0974ca3c996"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WSAD"",
                    ""id"": ""41dcb28e-0c86-4bb5-8c49-95638dbef1e7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a735c597-167f-44ec-aca2-062c644b7cc2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1e5c9506-3bc5-4e54-b1ed-fa2a24dcc5a2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5bbf4ae2-f2e0-40e7-be93-ef00a2dae258"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8dce9687-e29f-4661-8ae3-9fbd90a01e7e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""a02e92c2-d943-4fe3-97f8-18d1a0ee872f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""37f5abb6-02bb-48cb-9f5f-6999c4dda858"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""00ce7890-95e7-4d41-b8b9-38f43f5fbe69"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""75aacd8b-db9a-4e8a-92ea-1165573969d9"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6c1dc614-664e-49bd-8b51-6dd7efd83bfb"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""71a41ef5-35be-4ae8-85a8-c6db068bc62e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""89b014fd-52a1-47b4-a224-39bf3f845a9c"",
                    ""path"": ""<DualShockGamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1b658906-7fb3-403c-84bf-cb53799804d7"",
                    ""path"": ""<DualShockGamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""751e3a12-054d-4fb8-9baa-7298f1ca6bd2"",
                    ""path"": ""<DualShockGamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fa00ade2-cae3-4cb8-b045-91444673ce9b"",
                    ""path"": ""<DualShockGamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2de868e4-e20a-4b9a-bcd5-757b6f2ff86c"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dodge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e613521f-6090-4c2c-99eb-46245021e214"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dodge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dfdff14e-8dc8-4116-b0c0-7b9ad0702dd0"",
                    ""path"": ""<DualShockGamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dodge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7e9aa32-59dc-4da9-9323-c05992b5e8dc"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d646acb2-b133-4648-9d7b-8cff849bdee3"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6f1fd68-663b-4740-bec9-9c9f298c42e2"",
                    ""path"": ""<DualShockGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b4e5573-0fad-4f2f-9a08-6858a295a6ea"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a298394d-d25d-4955-875a-6836c1a51e2f"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""780bea0e-56b1-4cd1-ba1e-959d4c5c7977"",
                    ""path"": ""<DualShockGamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09d71eae-8fde-4310-90ca-581c3398d16e"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62a1a409-4435-410d-be68-699af3d150c2"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16e5668b-179c-40a7-8d9d-5b00c7973ebf"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AlternativeShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b53118e-63f1-4830-805a-f962bbca293e"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AlternativeShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // InGame
            m_InGame = asset.FindActionMap("InGame", throwIfNotFound: true);
            m_InGame_Movement = m_InGame.FindAction("Movement", throwIfNotFound: true);
            m_InGame_Dodge = m_InGame.FindAction("Dodge", throwIfNotFound: true);
            m_InGame_Look = m_InGame.FindAction("Look", throwIfNotFound: true);
            m_InGame_Shoot = m_InGame.FindAction("Shoot", throwIfNotFound: true);
            m_InGame_Reload = m_InGame.FindAction("Reload", throwIfNotFound: true);
            m_InGame_AlternativeShoot = m_InGame.FindAction("AlternativeShoot", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        // InGame
        private readonly InputActionMap m_InGame;
        private IInGameActions m_InGameActionsCallbackInterface;
        private readonly InputAction m_InGame_Movement;
        private readonly InputAction m_InGame_Dodge;
        private readonly InputAction m_InGame_Look;
        private readonly InputAction m_InGame_Shoot;
        private readonly InputAction m_InGame_Reload;
        private readonly InputAction m_InGame_AlternativeShoot;
        public struct InGameActions
        {
            private @InputSystem m_Wrapper;
            public InGameActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_InGame_Movement;
            public InputAction @Dodge => m_Wrapper.m_InGame_Dodge;
            public InputAction @Look => m_Wrapper.m_InGame_Look;
            public InputAction @Shoot => m_Wrapper.m_InGame_Shoot;
            public InputAction @Reload => m_Wrapper.m_InGame_Reload;
            public InputAction @AlternativeShoot => m_Wrapper.m_InGame_AlternativeShoot;
            public InputActionMap Get() { return m_Wrapper.m_InGame; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(InGameActions set) { return set.Get(); }
            public void SetCallbacks(IInGameActions instance)
            {
                if (m_Wrapper.m_InGameActionsCallbackInterface != null)
                {
                    @Movement.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnMovement;
                    @Dodge.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnDodge;
                    @Dodge.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnDodge;
                    @Dodge.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnDodge;
                    @Look.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnLook;
                    @Look.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnLook;
                    @Look.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnLook;
                    @Shoot.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnShoot;
                    @Shoot.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnShoot;
                    @Shoot.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnShoot;
                    @Reload.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnReload;
                    @Reload.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnReload;
                    @Reload.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnReload;
                    @AlternativeShoot.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnAlternativeShoot;
                    @AlternativeShoot.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnAlternativeShoot;
                    @AlternativeShoot.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnAlternativeShoot;
                }
                m_Wrapper.m_InGameActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @Dodge.started += instance.OnDodge;
                    @Dodge.performed += instance.OnDodge;
                    @Dodge.canceled += instance.OnDodge;
                    @Look.started += instance.OnLook;
                    @Look.performed += instance.OnLook;
                    @Look.canceled += instance.OnLook;
                    @Shoot.started += instance.OnShoot;
                    @Shoot.performed += instance.OnShoot;
                    @Shoot.canceled += instance.OnShoot;
                    @Reload.started += instance.OnReload;
                    @Reload.performed += instance.OnReload;
                    @Reload.canceled += instance.OnReload;
                    @AlternativeShoot.started += instance.OnAlternativeShoot;
                    @AlternativeShoot.performed += instance.OnAlternativeShoot;
                    @AlternativeShoot.canceled += instance.OnAlternativeShoot;
                }
            }
        }
        public InGameActions @InGame => new InGameActions(this);
        public interface IInGameActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnDodge(InputAction.CallbackContext context);
            void OnLook(InputAction.CallbackContext context);
            void OnShoot(InputAction.CallbackContext context);
            void OnReload(InputAction.CallbackContext context);
            void OnAlternativeShoot(InputAction.CallbackContext context);
        }
    }
}
