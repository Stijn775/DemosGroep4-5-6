using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TodoApp
{
    class RelayCommand : ICommand
    {
        Func<bool> canExecute;
        Action execute;

        public RelayCommand( Action execute, Func<bool> canExecute = null)
        {
            this.canExecute = canExecute ?? (() => execute!= null);
            this.execute = execute;
        }

        event EventHandler? ICommand.CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }

            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object? parameter)
        {
            return canExecute();
        }

        public void Execute(object? parameter)
        {
            execute();
        }
    }
}
