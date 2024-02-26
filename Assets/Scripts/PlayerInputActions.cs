//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input"",
    ""maps"": [
        {
            ""name"": ""PlayScene"",
            ""id"": ""47e0ea98-4fda-48f5-b921-ab80d6face32"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""054e4943-d3f9-47c5-9fe9-43160e04a61b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""b815f55a-7c79-43ee-95a2-e80e181a95d6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""09c7045e-8f72-4ad8-9956-b0250e6fb198"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c643a9ae-dbd0-47a7-aad3-d87f3d478a8f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""67c7c315-5b70-435e-9b03-054a72158228"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8d176e92-b457-46f8-a216-48ac155a8c4e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayScene
        m_PlayScene = asset.FindActionMap("PlayScene", throwIfNotFound: true);
        m_PlayScene_move = m_PlayScene.FindAction("move", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayScene
    private readonly InputActionMap m_PlayScene;
    private List<IPlaySceneActions> m_PlaySceneActionsCallbackInterfaces = new List<IPlaySceneActions>();
    private readonly InputAction m_PlayScene_move;
    public struct PlaySceneActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlaySceneActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_PlayScene_move;
        public InputActionMap Get() { return m_Wrapper.m_PlayScene; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlaySceneActions set) { return set.Get(); }
        public void AddCallbacks(IPlaySceneActions instance)
        {
            if (instance == null || m_Wrapper.m_PlaySceneActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlaySceneActionsCallbackInterfaces.Add(instance);
            @move.started += instance.OnMove;
            @move.performed += instance.OnMove;
            @move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IPlaySceneActions instance)
        {
            @move.started -= instance.OnMove;
            @move.performed -= instance.OnMove;
            @move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IPlaySceneActions instance)
        {
            if (m_Wrapper.m_PlaySceneActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlaySceneActions instance)
        {
            foreach (var item in m_Wrapper.m_PlaySceneActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlaySceneActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlaySceneActions @PlayScene => new PlaySceneActions(this);
    public interface IPlaySceneActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
