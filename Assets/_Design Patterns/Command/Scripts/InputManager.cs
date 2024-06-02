using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private StrategemManager _strategemManager;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            RunInputCommand(_strategemManager, KeyCode.UpArrow);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            RunInputCommand(_strategemManager, KeyCode.DownArrow);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            RunInputCommand(_strategemManager, KeyCode.LeftArrow);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RunInputCommand(_strategemManager, KeyCode.RightArrow);
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            CommandInvoker.UndoCommand();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            CommandInvoker.RedoCommand();
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            RunInputCommand(_strategemManager, KeyCode.Escape);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            RunInputCommand(_strategemManager, KeyCode.Return);
        }
    }

    private void RunInputCommand(StrategemManager strategemManager, KeyCode keyCode)
    {
        ICommand command = new DirectionCommand(strategemManager, keyCode);

        CommandInvoker.ExecuteCommand(command);
    }
}
