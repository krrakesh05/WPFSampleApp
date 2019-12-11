using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfSampleApp;

namespace WpfApplication2
{
   public class AddCustomerCommand
    {
        public LoginCommand ClickCommand { set; get; }


        public AddCustomerCommand()
        {
            ClickCommand = new LoginCommand(ExecuteMethod, CanExecuteMethod);
        }


        public bool CanExecuteMethod(object Parameter)
        {
            return true;
        }

        public void ExecuteMethod(object Parameter)
        {
            var handsOnWidow = new MainWindow();
            //handsOnWidow;

            //var handsOnWidow = new frame();
            //handsOnWidow;

            AddCustomer p = new AddCustomer();
            //MainWindow.na(p);
        }
    }
}
