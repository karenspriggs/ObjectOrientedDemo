using System;
using System.Windows;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;

public class BasicCommand : ICommand
{
    private Action commandAction;

    public event EventHandler CanExecuteChanged = (sender, e) => { };

    public BasicCommand(Action action)
    {
        commandAction = action;
    }

    public BasicCommand(Action action, object parameter)
    {
        commandAction = action;
    }

    public bool CanExecute(object parameter)
    {
        return true;
    }

    public void Execute(object parameter)
    {
        commandAction();
    }
}