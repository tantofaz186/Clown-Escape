using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class UICamera : MonoBehaviour
{
    private Camera camera;
    private AudioListener listener;

    private void Awake()
    {
        camera = GetComponent<Camera>();
        listener = GetComponent<AudioListener>();
    }

    private void OnEnable()
    {
        SceneManager.activeSceneChanged += DisableComponents;
    }
    private void OnDisable()
    {
        SceneManager.activeSceneChanged -= DisableComponents;
    }
    private void DisableComponents(Scene oldScene, Scene newScene)
    {
        camera.enabled = listener.enabled = newScene == gameObject.scene;
    }
}
