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
                },
                {
                    ""name"": ""Four Contacts"",
                    ""type"": ""PassThrough"",
                    ""id"": ""41c1964c-0748-4ac7-99a1-eb357ebfa7e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Five Contacts"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e5ed2186-fb97-421b-937a-6b094e85d9e3"",
                    ""expectedControlType"": ""Button"",
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
                    ""groups"": ""Touch"",
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
                    ""groups"": ""Touch"",
                    ""action"": ""Primary Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58ada81a-8d60-4ace-b55c-e88bbdaff3b0"",
                    ""path"": ""<Touchscreen>/touch4/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Five Contacts"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f77f2daa-1649-4c74-9da7-2ef6feef5844"",
                    ""path"": ""<Touchscreen>/touch3/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Four Contacts"",
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
                },
                {
                    ""name"": ""Invincibility"",
                    ""type"": ""Button"",
                    ""id"": ""47d90251-31b0-4d80-a650-5321d551384e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LevelSelect"",
                    ""type"": ""Button"",
                    ""id"": ""4459735c-9a5e-4e84-acc4-51cb6f963aca"",
                    ""expectedControlType"": ""Button"",
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
                    ""groups"": ""Mouse;Touch"",
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
                    ""groups"": ""Mouse;Touch"",
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
                    ""groups"": ""Mouse;Touch"",
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
                    ""groups"": ""Mouse;Touch"",
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
                    ""groups"": ""Mouse;Touch"",
                    ""action"": ""Teclas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34983a8d-2844-4855-a9fd-d3ad6b2978fc"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Invincibility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29c49f6f-b1a1-4894-ae0e-8931f9ebeb22"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LevelSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MousePort"",
            ""id"": ""16dccea9-5365-4a7c-b51e-32fe02ae87b7"",
            ""actions"": [
                {
                    ""name"": ""Primary Contact"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fb40dc53-d57a-4afb-b263-bb1292ad9966"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Primary Position"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7c0c1081-e4fc-4cb6-801c-f9761861e040"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bf397cbd-1b6e-494a-9af5-1a5ac1dee770"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""Primary Contact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d8c09bf-2d39-4440-b1ea-e9ccbdefef6e"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""Primary Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse"",
            ""bindingGroup"": ""Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Touch
        m_Touch = asset.FindActionMap("Touch", throwIfNotFound: true);
        m_Touch_PrimaryContact = m_Touch.FindAction("Primary Contact", throwIfNotFound: true);
        m_Touch_PrimaryPosition = m_Touch.FindAction("Primary Position", throwIfNotFound: true);
        m_Touch_FourContacts = m_Touch.FindAction("Four Contacts", throwIfNotFound: true);
        m_Touch_FiveContacts = m_Touch.FindAction("Five Contacts", throwIfNotFound: true);
        // Teclado Port
        m_TecladoPort = asset.FindActionMap("Teclado Port", throwIfNotFound: true);
        m_TecladoPort_Teclas = m_TecladoPort.FindAction("Teclas", throwIfNotFound: true);
        m_TecladoPort_Invincibility = m_TecladoPort.FindAction("Invincibility", throwIfNotFound: true);
        m_TecladoPort_LevelSelect = m_TecladoPort.FindAction("LevelSelect", throwIfNotFound: true);
        // MousePort
        m_MousePort = asset.FindActionMap("MousePort", throwIfNotFound: true);
        m_MousePort_PrimaryContact = m_MousePort.FindAction("Primary Contact", throwIfNotFound: true);
        m_MousePort_PrimaryPosition = m_MousePort.FindAction("Primary Position", throwIfNotFound: true);
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
    private readonly InputAction m_Touch_FourContacts;
    private readonly InputAction m_Touch_FiveContacts;
    public struct TouchActions
    {
        private @PlayerInput m_Wrapper;
        public TouchActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @PrimaryContact => m_Wrapper.m_Touch_PrimaryContact;
        public InputAction @PrimaryPosition => m_Wrapper.m_Touch_PrimaryPosition;
        public InputAction @FourContacts => m_Wrapper.m_Touch_FourContacts;
        public InputAction @FiveContacts => m_Wrapper.m_Touch_FiveContacts;
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
                @FourContacts.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnFourContacts;
                @FourContacts.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnFourContacts;
                @FourContacts.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnFourContacts;
                @FiveContacts.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnFiveContacts;
                @FiveContacts.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnFiveContacts;
                @FiveContacts.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnFiveContacts;
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
                @FourContacts.started += instance.OnFourContacts;
                @FourContacts.performed += instance.OnFourContacts;
                @FourContacts.canceled += instance.OnFourContacts;
                @FiveContacts.started += instance.OnFiveContacts;
                @FiveContacts.performed += instance.OnFiveContacts;
                @FiveContacts.canceled += instance.OnFiveContacts;
            }
        }
    }
    public TouchActions @Touch => new TouchActions(this);

    // Teclado Port
    private readonly InputActionMap m_TecladoPort;
    private ITecladoPortActions m_TecladoPortActionsCallbackInterface;
    private readonly InputAction m_TecladoPort_Teclas;
    private readonly InputAction m_TecladoPort_Invincibility;
    private readonly InputAction m_TecladoPort_LevelSelect;
    public struct TecladoPortActions
    {
        private @PlayerInput m_Wrapper;
        public TecladoPortActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Teclas => m_Wrapper.m_TecladoPort_Teclas;
        public InputAction @Invincibility => m_Wrapper.m_TecladoPort_Invincibility;
        public InputAction @LevelSelect => m_Wrapper.m_TecladoPort_LevelSelect;
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
                @Invincibility.started -= m_Wrapper.m_TecladoPortActionsCallbackInterface.OnInvincibility;
                @Invincibility.performed -= m_Wrapper.m_TecladoPortActionsCallbackInterface.OnInvincibility;
                @Invincibility.canceled -= m_Wrapper.m_TecladoPortActionsCallbackInterface.OnInvincibility;
                @LevelSelect.started -= m_Wrapper.m_TecladoPortActionsCallbackInterface.OnLevelSelect;
                @LevelSelect.performed -= m_Wrapper.m_TecladoPortActionsCallbackInterface.OnLevelSelect;
                @LevelSelect.canceled -= m_Wrapper.m_TecladoPortActionsCallbackInterface.OnLevelSelect;
            }
            m_Wrapper.m_TecladoPortActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Teclas.started += instance.OnTeclas;
                @Teclas.performed += instance.OnTeclas;
                @Teclas.canceled += instance.OnTeclas;
                @Invincibility.started += instance.OnInvincibility;
                @Invincibility.performed += instance.OnInvincibility;
                @Invincibility.canceled += instance.OnInvincibility;
                @LevelSelect.started += instance.OnLevelSelect;
                @LevelSelect.performed += instance.OnLevelSelect;
                @LevelSelect.canceled += instance.OnLevelSelect;
            }
        }
    }
    public TecladoPortActions @TecladoPort => new TecladoPortActions(this);

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
    private int m_MouseSchemeIndex = -1;
    public InputControlScheme MouseScheme
    {
        get
        {
            if (m_MouseSchemeIndex == -1) m_MouseSchemeIndex = asset.FindControlSchemeIndex("Mouse");
            return asset.controlSchemes[m_MouseSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    public interface ITouchActions
    {
        void OnPrimaryContact(InputAction.CallbackContext context);
        void OnPrimaryPosition(InputAction.CallbackContext context);
        void OnFourContacts(InputAction.CallbackContext context);
        void OnFiveContacts(InputAction.CallbackContext context);
    }
    public interface ITecladoPortActions
    {
        void OnTeclas(InputAction.CallbackContext context);
        void OnInvincibility(InputAction.CallbackContext context);
        void OnLevelSelect(InputAction.CallbackContext context);
    }
    public interface IMousePortActions
    {
        void OnPrimaryContact(InputAction.CallbackContext context);
        void OnPrimaryPosition(InputAction.CallbackContext context);
    }
}
