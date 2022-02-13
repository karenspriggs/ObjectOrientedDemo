using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CurrencyWPF.ViewModels.Commands
{
    public class CoinCommand : ICommand
    {
        public delegate void ICommandonExecute(object parameter);
        public delegate bool ICommandcanExecute(object parameter);

        private ICommandonExecute _execute;
        private ICommandcanExecute _canExecute;

        public CoinCommand(ICommandonExecute onExecute, ICommandcanExecute canExecute)
        {
            _execute = onExecute;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }
    }
}
