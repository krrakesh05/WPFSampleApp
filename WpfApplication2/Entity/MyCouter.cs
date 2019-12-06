using System;
using System.ComponentModel;
using System.Windows.Input;

namespace WpfApplication2.Entity
{
    public class MyCounter1 : INotifyPropertyChanged
    {

        private int _Counter;
        private CommandCounter _cmdCounter;

        public event PropertyChangedEventHandler PropertyChanged;
       

        public MyCounter1()
        {
            _cmdCounter = new CommandCounter(Increment, passValidation);
            Counter = 0;
        }

        public ICommand CommandCounterAction
        {
            get { return _cmdCounter; }
        }

        public int Counter
        {
            get { return _Counter; }
            set { _Counter = value; }
        }

        public void Increment(object parameter)
        {

            _Counter++;
            PropertyChanged(this, new PropertyChangedEventArgs("Counter"));
        }
        public bool passValidation(object parameter)
        {
            return true;
        }
    }
    public class CommandCounter : ICommand
    {
        public event EventHandler CanExecuteChanged;
        //public MyCounter1 obj;

        Action<object> ExecuteAction;
        Func<object, bool> canExecuteAction;


        public CommandCounter(Action<object> ExecuteAction, Func<object, bool> canExecuteAction)
        {
            this.ExecuteAction = ExecuteAction;
            this.canExecuteAction = canExecuteAction;
        }

        public bool CanExecute(object parameter) // When it will be run
        {
            return canExecuteAction(parameter);
        }

        public void Execute(object parameter)// what it will be execute..
        {
            ExecuteAction(parameter);
        }
    }
}
