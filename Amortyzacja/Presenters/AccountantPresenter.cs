using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amortyzacja.Forms;
using Amortyzacja.Navigaton;
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
            
            Navigator.GetInstance().Navigate((Form)_accountantView,new AmortizationForm());
        }

        public void RegisterSoftware()
        {
            Navigator.GetInstance().Navigate((Form)_accountantView,new RegisterAssetsForm());

        }

        public void RegisterHardware()
        {
            Navigator.GetInstance().Navigate((Form)_accountantView, new RegisterAssetsForm());
        }
        public void Logout()
        {
            Navigator.GetInstance().Navigate((Form)_accountantView, new LoginForm());
        }
    }
}
