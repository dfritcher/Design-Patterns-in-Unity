using System.Collections;
using System.Collections.Generic;

public class CommandInvoker
{
    // stack of command objects to undo
    private static Stack<ICommand> _undoStack = new();
    // second stack of redoable commands
    private static Stack<ICommand> _redoStack = new();

    // execute a command object directly and save to the undo stack
    public static void ExecuteCommand(ICommand command)
    {
        command.Execute();
        _undoStack.Push(command);

        // clear out the redo stack if we make a new move
        _redoStack.Clear();
    }

    public static void UndoCommand()
    {
        if (_undoStack.Count > 0)
        {
            ICommand activeCommand = _undoStack.Pop();
            _redoStack.Push(activeCommand);
            activeCommand.Undo();
        }
    }

    public static void RedoCommand()
    {
        if (_redoStack.Count > 0)
        {
            ICommand activeCommand = _redoStack.Pop();
            _undoStack.Push(activeCommand);
            activeCommand.Execute();
        }
    }
}