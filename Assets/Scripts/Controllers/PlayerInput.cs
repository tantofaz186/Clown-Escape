// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controllers/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

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
            ""id"": ""e15df24d-66e5-409e-bacc-ca467c4ddc56"",
            ""actions"": [
                {
                    ""name"": ""Primary Contact"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b784c2ff-a683-43ed-b151-8e119d1b6dd7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Primary Position"",
                    ""type"": ""PassThrough"",
                    ""id"": ""074082bc-89b3-4ced-9b95-2087b8586bf8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f6014e44-5c14-4c84-a311-a63f7408afaf"",
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
                    ""id"": ""b277fe72-06b9-46f6-b11a-3f683e83329f"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MousePort"",
            ""id"": ""99a6a163-7ae0-4964-815c-903911ad9861"",
            ""actions"": [
                {
                    ""name"": ""Primary Contact"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ca1b4bf6-0de3-43ec-af6a-72df860c69dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Primary Position"",
                    ""type"": ""PassThrough"",
                    ""id"": ""729b7acf-8949-4d07-b85e-78e72f9e519e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""079f815f-d3d8-4897-8eeb-8c2784410dbe"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary Contact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""353fea26-e379-4c81-afb6-b599718e72fb"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Teclado Port"",
            ""id"": ""0f47e923-87ce-4d0b-8781-0a9729013ccf"",
            ""actions"": [
                {
                    ""name"": ""Teclas"",
                    ""type"": ""PassThrough"",
                    ""id"": ""69a3e163-4328-4da1-94b7-64a7960eea13"",
                    ""expectedControlType"": ""Key"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""29ae9799-6690-476a-8c79-acd1fd8a6173"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Teclas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ab7bba5-cc17-4867-8dfb-7d79a7eb3377"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Teclas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""874157da-07a2-48f6-81b4-e208eb8559d6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Teclas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f316204f-e02a-4638-8f76-562bda11fb14"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Teclas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15eda61c-2376-444a-896d-1fe89c7f64f4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Teclas"",
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
        // MousePort
        m_MousePort = asset.FindActionMap("MousePort", throwIfNotFound: true);
        m_MousePort_PrimaryContact = m_MousePort.FindAction("Primary Contact", throwIfNotFound: true);
        m_MousePort_PrimaryPosition = m_MousePort.FindAction("Primary Position", throwIfNotFound: true);
        // Teclado Port
        m_TecladoPort = asset.FindActionMap("Teclado Port", throwIfNotFound: true);
        m_TecladoPort_Teclas = m_TecladoPort.FindAction("Teclas", throwIfNotFound: true);
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

    // MousePort
    private readonly InputActionMap m_MousePort;
    private IMousePortActions m_MousePortActionsCallbackInterface;
    private readonly InputAction m_MousePort_PrimaryContact;
    private readonly InputAction m_MousePort_PrimaryPosition;
    public struct MousePortActions
    {
        private @PlayerInput m_Wrapper;
        public MousePortActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @PrimaryContact => m_Wrapper.m_MousePort_PrimaryContact;
        public InputAction @PrimaryPosition => m_Wrapper.m_MousePort_PrimaryPosition;
        public InputActionMap Get() { return m_Wrapper.m_MousePort; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MousePortActions set) { return set.Get(); }
        public void SetCallbacks(IMousePortActions instance)
        {
            if (m_Wrapper.m_MousePortActionsCallbackInterface != null)
            {
                @PrimaryContact.started -= m_Wrapper.m_MousePortActionsCallbackInterface.OnPrimaryContact;
                @PrimaryContact.performed -= m_Wrapper.m_MousePortActionsCallbackInterface.OnPrimaryContact;
                @PrimaryContact.canceled -= m_Wrapper.m_MousePortActionsCallbackInterface.OnPrimaryContact;
                @PrimaryPosition.started -= m_Wrapper.m_MousePortActionsCallbackInterface.OnPrimaryPosition;
                @PrimaryPosition.performed -= m_Wrapper.m_MousePortActionsCallbackInterface.OnPrimaryPosition;
                @PrimaryPosition.canceled -= m_Wrapper.m_MousePortActionsCallbackInterface.OnPrimaryPosition;
            }
            m_Wrapper.m_MousePortActionsCallbackInterface = instance;
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
    public MousePortActions @MousePort => new MousePortActions(this);

    // Teclado Port
    private readonly InputActionMap m_TecladoPort;
    private ITecladoPortActions m_TecladoPortActionsCallbackInterface;
    private readonly InputAction m_TecladoPort_Teclas;
    public struct TecladoPortActions
    {
        private @PlayerInput m_Wrapper;
        public TecladoPortActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Teclas => m_Wrapper.m_TecladoPort_Teclas;
        public InputActionMap Get() { return m_Wrapper.m_TecladoPort; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TecladoPortActions set) { return set.Get(); }
        public void SetCallbacks(ITecladoPortActions instance)
        {
            if (m_Wrapper.m_TecladoPortActionsCallbackInterface != null)
            {
                @Teclas.started -= m_Wrapper.m_TecladoPortActionsCallbackInterface.OnTeclas;
                @Teclas.performed -= m_Wrapper.m_TecladoPortActionsCallbackInterface.OnTeclas;
                @Teclas.canceled -= m_Wrapper.m_TecladoPortActionsCallbackInterface.OnTeclas;
            }
            m_Wrapper.m_TecladoPortActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Teclas.started += instance.OnTeclas;
                @Teclas.performed += instance.OnTeclas;
                @Teclas.canceled += instance.OnTeclas;
            }
        }
    }
    public TecladoPortActions @TecladoPort => new TecladoPortActions(this);
    public interface ITouchActions
    {
        void OnPrimaryContact(InputAction.CallbackContext context);
        void OnPrimaryPosition(InputAction.CallbackContext context);
    }
    public interface IMousePortActions
    {
        void OnPrimaryContact(InputAction.CallbackContext context);
        void OnPrimaryPosition(InputAction.CallbackContext context);
    }
    public interface ITecladoPortActions
    {
        void OnTeclas(InputAction.CallbackContext context);
    }
}
