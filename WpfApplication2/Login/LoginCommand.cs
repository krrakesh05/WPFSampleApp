using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfSampleApp
{
    public class LoginCommand : ICommand
    {
        Action<object> execute;
        Func<object, bool> canExecute;
        //
        // Summary:
        //     Occurs when changes occur that affect whether or not the command should execute.
        public event EventHandler CanExecuteChanged;

        public LoginCommand(Action<object> _execute, Func<object, bool> _canExecute)
        {
            this.execute = _execute;
            this.canExecute = _canExecute;
        }
        

        //
        // Summary:
        //     Defines the method that determines whether the command can execute in its current
        //     state.
        //
        // Parameters:
        //   parameter:
        //     Data used by the command. If the command does not require data to be passed,
        //     this object can be set to null.
        //
        // Returns:
        //     true if this command can be executed; otherwise, false.
        public bool CanExecute(object parameter)
        {
            return canExecute(parameter);
        }
        //
        // Summary:
        //     Defines the method to be called when the command is invoked.
        //
        // Parameters:
        //   parameter:
        //     Data used by the command. If the command does not require data to be passed,
        //     this object can be set to null.
        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
