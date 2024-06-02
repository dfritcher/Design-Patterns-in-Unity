using UnityEngine;

public class DirectionCommand : ICommand
{

    private KeyCode _keyCode;
    private StrategemManager _manager;
    
    public DirectionCommand(StrategemManager strategemManager, KeyCode keyCode)
    {
        _keyCode = keyCode;
        _manager = strategemManager;
    }

    public void Execute()
    {
        _manager.AddDirection(_keyCode);
    }

    public void Undo()
    {
        _manager.RemoveDirection(_keyCode);
    }
}