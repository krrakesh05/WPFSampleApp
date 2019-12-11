using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApplication2;

namespace WpfSampleApp
{
    public class LoginButtonClick
    {
        public LoginCommand myCommnad { set; get; }


        public LoginButtonClick()
        {
            myCommnad = new LoginCommand(ExecuteMethod, CanExecuteMethod);
        }


        public bool CanExecuteMethod(object Parameter)
        {
            return true;
        }

        public void ExecuteMethod(object Parameter)
        {
            var loginWindow = new MainWindow();
            loginWindow.ShowDialog();

            //var loginWindow = new CustomerOrders();
            //loginWindow.ShowDialog();

            //var handsOnWidow = new CustomerOrders();
            //handsOnWidow.Show();




        }
    }
}
