// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controllers/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Controllers
{
    public class @PlayerInput : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Touch"",
            ""id"": ""07e14a32-bc38-4956-bc66-25adcbe0ee4d"",
            ""actions"": [
                {
                    ""name"": ""Primary Contact"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3ed02aff-45bc-45f6-a269-efafc1d86ed3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Primary Position"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bd811f88-266a-4431-b657-c7cc53ee6f9e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a21a5748-8843-45d6-af6b-e44a546997d6"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary Contact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7fb09d70-94c2-48d8-a7c8-8ce7e8011b0f"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Touch
            m_Touch = asset.FindActionMap("Touch", throwIfNotFound: true);
            m_Touch_PrimaryContact = m_Touch.FindAction("Primary Contact", throwIfNotFound: true);
            m_Touch_PrimaryPosition = m_Touch.FindAction("Primary Position", throwIfNotFound: true);
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

        // Touch
        private readonly InputActionMap m_Touch;
        private ITouchActions m_TouchActionsCallbackInterface;
        private readonly InputAction m_Touch_PrimaryContact;
        private readonly InputAction m_Touch_PrimaryPosition;
        public struct TouchActions
        {
            private @PlayerInput m_Wrapper;
            public TouchActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @PrimaryContact => m_Wrapper.m_Touch_PrimaryContact;
            public InputAction @PrimaryPosition => m_Wrapper.m_Touch_PrimaryPosition;
            public InputActionMap Get() { return m_Wrapper.m_Touch; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(TouchActions set) { return set.Get(); }
            public void SetCallbacks(ITouchActions instance)
            {
                if (m_Wrapper.m_TouchActionsCallbackInterface != null)
                {
                    @PrimaryContact.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryContact;
                    @PrimaryContact.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryContact;
                    @PrimaryContact.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryContact;
                    @PrimaryPosition.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryPosition;
                    @PrimaryPosition.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryPosition;
                    @PrimaryPosition.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryPosition;
                }
                m_Wrapper.m_TouchActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @PrimaryContact.started += instance.OnPrimaryContact;
                    @PrimaryContact.performed += instance.OnPrimaryContact;
                    @PrimaryContact.canceled += instance.OnPrimaryContact;
                    @PrimaryPosition.started += instance.OnPrimaryPosition;
                    @PrimaryPosition.performed += instance.OnPrimaryPosition;
                    @PrimaryPosition.canceled += instance.OnPrimaryPosition;
                }
            }
        }
        public TouchActions @Touch => new TouchActions(this);
        public interface ITouchActions
        {
            void OnPrimaryContact(InputAction.CallbackContext context);
            void OnPrimaryPosition(InputAction.CallbackContext context);
        }
    }
}
