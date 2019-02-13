using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amortyzacja.Forms;
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
            AddWorkerForm addWorkerForm=new AddWorkerForm();
            addWorkerForm.Show();
            (_accountantView as AccountantForm).Hide();

        }

        public void DeleteWorker()
        {
            DeleteWorkerForm deleteWorkerForm=new DeleteWorkerForm();
            deleteWorkerForm.Show();
            (_accountantView as AccountantForm).Hide();
        }

        public void DeleteSoftware()
        {

        }

        public void DeleteHardware()
        {

        }

        public void Amortization()
        {
            AmortizationForm amortizationForm=new AmortizationForm();
            amortizationForm.Show();
            (_accountantView as AccountantForm).Hide();
        }

        public void RegisterSoftware()
        {
            RegisterSoftwareForm registerSoftwareForm=new RegisterSoftwareForm();
            registerSoftwareForm.Show();
            (_accountantView as AccountantForm).Hide();

        }

        public void RegisterHardware()
        {
            RegisterHardwareForm registerHardwareForm=new RegisterHardwareForm();
            registerHardwareForm.Show();
            (_accountantView as AccountantForm).Hide();
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
