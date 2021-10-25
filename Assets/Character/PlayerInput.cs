// GENERATED AUTOMATICALLY FROM 'Assets/Character/PlayerInput.inputactions'

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
            ""name"": ""Ingame"",
            ""id"": ""c3579a2a-a01a-4aed-aa89-9be23698b7fc"",
            ""actions"": [
                {
                    ""name"": ""Steer_Vertical"",
                    ""type"": ""Value"",
                    ""id"": ""09c9fa11-35d9-42cd-a6c1-79e5fcc6e008"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Steer_Horizontal"",
                    ""type"": ""Button"",
                    ""id"": ""a57859d1-c5fb-4a04-95a2-198d7b1b1ed0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Button"",
                    ""id"": ""1f353e90-07d6-4b29-ad35-4403a9173e1e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Vertical Steer"",
                    ""id"": ""81e34700-abb6-4d53-80d3-de867b2579fe"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer_Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""006ccf88-207c-4794-bfaf-9d5e9811a7d7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Steer_Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6fddc32f-80f7-4d33-8c8d-d93c3a1ece61"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Steer_Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Horizontal Steer"",
                    ""id"": ""7a5c83f8-0267-4d00-b836-30d3c0799b53"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer_Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""65af8307-16ee-42a6-8c85-00de3bbeddef"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Steer_Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""eb9fa571-087f-41dc-b283-f99879b3a457"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Steer_Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5fce34c1-6e61-48b3-9e04-a1eb0d714650"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Ingame
        m_Ingame = asset.FindActionMap("Ingame", throwIfNotFound: true);
        m_Ingame_Steer_Vertical = m_Ingame.FindAction("Steer_Vertical", throwIfNotFound: true);
        m_Ingame_Steer_Horizontal = m_Ingame.FindAction("Steer_Horizontal", throwIfNotFound: true);
        m_Ingame_Accelerate = m_Ingame.FindAction("Accelerate", throwIfNotFound: true);
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

    // Ingame
    private readonly InputActionMap m_Ingame;
    private IIngameActions m_IngameActionsCallbackInterface;
    private readonly InputAction m_Ingame_Steer_Vertical;
    private readonly InputAction m_Ingame_Steer_Horizontal;
    private readonly InputAction m_Ingame_Accelerate;
    public struct IngameActions
    {
        private @PlayerInput m_Wrapper;
        public IngameActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Steer_Vertical => m_Wrapper.m_Ingame_Steer_Vertical;
        public InputAction @Steer_Horizontal => m_Wrapper.m_Ingame_Steer_Horizontal;
        public InputAction @Accelerate => m_Wrapper.m_Ingame_Accelerate;
        public InputActionMap Get() { return m_Wrapper.m_Ingame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(IngameActions set) { return set.Get(); }
        public void SetCallbacks(IIngameActions instance)
        {
            if (m_Wrapper.m_IngameActionsCallbackInterface != null)
            {
                @Steer_Vertical.started -= m_Wrapper.m_IngameActionsCallbackInterface.OnSteer_Vertical;
                @Steer_Vertical.performed -= m_Wrapper.m_IngameActionsCallbackInterface.OnSteer_Vertical;
                @Steer_Vertical.canceled -= m_Wrapper.m_IngameActionsCallbackInterface.OnSteer_Vertical;
                @Steer_Horizontal.started -= m_Wrapper.m_IngameActionsCallbackInterface.OnSteer_Horizontal;
                @Steer_Horizontal.performed -= m_Wrapper.m_IngameActionsCallbackInterface.OnSteer_Horizontal;
                @Steer_Horizontal.canceled -= m_Wrapper.m_IngameActionsCallbackInterface.OnSteer_Horizontal;
                @Accelerate.started -= m_Wrapper.m_IngameActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_IngameActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_IngameActionsCallbackInterface.OnAccelerate;
            }
            m_Wrapper.m_IngameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Steer_Vertical.started += instance.OnSteer_Vertical;
                @Steer_Vertical.performed += instance.OnSteer_Vertical;
                @Steer_Vertical.canceled += instance.OnSteer_Vertical;
                @Steer_Horizontal.started += instance.OnSteer_Horizontal;
                @Steer_Horizontal.performed += instance.OnSteer_Horizontal;
                @Steer_Horizontal.canceled += instance.OnSteer_Horizontal;
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
            }
        }
    }
    public IngameActions @Ingame => new IngameActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IIngameActions
    {
        void OnSteer_Vertical(InputAction.CallbackContext context);
        void OnSteer_Horizontal(InputAction.CallbackContext context);
        void OnAccelerate(InputAction.CallbackContext context);
    }
}
