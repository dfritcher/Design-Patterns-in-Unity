using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomeSceneManager : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void OnMainButtonClicked()
    {
        SceneManager.LoadScene("Main Scene");
    }

    public void ObserverButtonClicked()
    {
        SceneManager.LoadScene("Observer_Pattern");
    }

    public void CommandButtonClicked()
    {
        SceneManager.LoadScene("Command_Pattern");
    }

    public void FactoryButtonClicked()
    {
        SceneManager.LoadScene("Factory_Pattern");
    }

    public void StateButtonClicked()
    {
        SceneManager.LoadScene("State_Pattern");
    }
}
