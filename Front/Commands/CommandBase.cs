using System;
using System.Windows.Input;

namespace Front.Commands
{
    public class CommandBase : ICommand
    {

        public Predicate<object> CanExecuteDelegate { get; set; }
        public Action<object> ExecuteDelegate { get; set; }
        public CommandBase(Action<object> action)
        {
            ExecuteDelegate = action;
        }

        public bool CanExecute(object parameter)
        {
            if (CanExecuteDelegate != null)
            {
                return CanExecuteDelegate(parameter);
            }

            return true;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            if (ExecuteDelegate != null)
            {
                ExecuteDelegate(parameter);
            }
        }
    }
}
