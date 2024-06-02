using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StrategemManager : MonoBehaviour
{
    [SerializeField] private GameObject _up;
    [SerializeField] private GameObject _down;
    [SerializeField] private GameObject _left;
    [SerializeField] private GameObject _right;
    [SerializeField] private Transform _inputParent;
    [SerializeField] private Strategem[] _strategems;
    
    private int _inputNum = 0;
    private Direction _direction;
    internal void AddDirection(KeyCode keyCode)
    {
        // Create a new image to show user input
        switch(keyCode)
        {
            case KeyCode.UpArrow:
                Instantiate(_up, _inputParent, true);
                _direction = Direction.Up;
                break;
            case KeyCode.DownArrow:
                Instantiate(_down, _inputParent, true);
                _direction = Direction.Down;
                break;
            case KeyCode.LeftArrow:
                Instantiate(_left, _inputParent, true);
                _direction = Direction.Left;
                break;
            case KeyCode.RightArrow:
                Instantiate(_right, _inputParent, true);
                _direction = Direction.Right;
                break;
            default:
                break;
        }
        foreach(var strat in _strategems)
        {
            strat.RegisterInput(_direction, _inputNum);
        }
        _inputNum++;
    }

    internal void RemoveDirection(KeyCode keyCode)
    {
        _inputNum--;
        Destroy(_inputParent.GetChild(_inputParent.childCount - 1).gameObject);
    }
}
