using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandSceneManager : MonoBehaviour
{
    private CustomeSceneManager _sceneManager;
    // Start is called before the first frame update
    void Start()
    {
        _sceneManager = FindAnyObjectByType<CustomeSceneManager>();
    }

    public void OnMainSceneButtonClicked()
    {
        _sceneManager.OnMainButtonClicked();
    }
}
