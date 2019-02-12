using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amortyzacja.View;

namespace Amortyzacja.Presenter
{
    public class AccountantPresenter
    {
        private IAccountantView _accountantView = null;
        public AccountantPresenter(IAccountantView accountantView)
        {
            _accountantView = accountantView;
        }

        public void AddWorker()
        {


        }

        public void DeleteWorker()
        {

        }

        public void DeleteSoftware()
        {

        }

        public void DeleteHardware()
        {

        }

        public void Amortization()
        {

        }

        public void RegisterSoftware()
        {

        }

        public void RegisterHardware()
        {

        }
        public void Logout()
        {
            LoginForm loginForm=new LoginForm();
            LoginPresenter loginPresenter=new LoginPresenter(loginForm);
            (_accountantView as AccountantForm).Hide();
            loginForm.Show();
        }
    }
}
