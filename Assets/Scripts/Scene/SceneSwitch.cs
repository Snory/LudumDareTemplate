using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public string CurrentScene;
    public BoolVariable Additive;


    [SerializeField]
    private EventSystem _eventSystemInScene;

    [SerializeField]
    private AudioListener _audioListenerInScene;

    [SerializeField]
    private SceneTransitionBase _sceneTransition;

    
    public void SwitchScene(string NextSceneName)
    {
        Debug.Log("Switch scene");
        if (_eventSystemInScene != null)
        {
            _eventSystemInScene.enabled = false;
        }

        if (_audioListenerInScene != null)
        {
            _audioListenerInScene.enabled = false;
        }

        _sceneTransition.TransitToScene(CurrentScene, NextSceneName, Additive.Value);
    }

}
