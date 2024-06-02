using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Strategem : MonoBehaviour
{
    [SerializeField] private GameObject _up;
    [SerializeField] private GameObject _down;
    [SerializeField] private GameObject _left;
    [SerializeField] private GameObject _right;

    [SerializeField] List<Direction> _directions;

    [SerializeField] private Image _background;
    [SerializeField] private Transform _inputParent;
    [SerializeField] private Color _originalColor;
    [SerializeField] private Color _highlightColor;
    [SerializeField] private List<Image> _codes;

    private void Awake()
    {
        foreach(var direction in _directions)
        {
            switch(direction)
            {
                case Direction.Up:
                    _codes.Add(Instantiate(_up, _inputParent, true).GetComponent<Image>());
                    break;
                case Direction.Down:
                    _codes.Add(Instantiate(_down, _inputParent, true).GetComponent<Image>());
                    break;
                case Direction.Left:
                    _codes.Add(Instantiate(_left, _inputParent, true).GetComponent<Image>());
                    break;
                case Direction.Right:
                    _codes.Add(Instantiate(_right, _inputParent, true).GetComponent<Image>());
                    break;
                default:
                    break;
            }
        }
    }

    public void RegisterInput(Direction direction, int position)
    {
        if (position >= _codes.Count)
            return;

        if (_directions[position] == direction) {
            _codes[position].color = _highlightColor;
        }
        else { 
            //SetEnabledState(false); 
        }
    }

    public void SetEnabledState(bool enabled)
    {
        gameObject.SetActive(enabled);
    }
}
