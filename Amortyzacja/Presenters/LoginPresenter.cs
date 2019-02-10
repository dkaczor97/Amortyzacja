using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amortyzacja.Forms;
using Amortyzacja.View;

namespace Amortyzacja.Presenter
{
    public class LoginPresenter
    {
        private ILoginView _loginView;
        
        public LoginPresenter(ILoginView loginView)
        {
            _loginView = loginView;
            _loginView.Presenter = this;
        }

        public void LoginToApp(string login, string password)
        {
            //Account account=new Account(){UserLogin = login,UserPassword = password};
            IODatabaseEntities db=new IODatabaseEntities();
            var result = db.Accounts.FirstOrDefault(account => account.UserLogin == login&&account.UserPassword==password);
            if (result != null)
            {
                Worker worker = result.Worker;
                AppSession.GetInstance().CurrentWorker = worker;
                LoginForm loginForm = _loginView as LoginForm;
                if (result.Permission == 0)
                {
                    WorkerForm workerForm=new WorkerForm();
                    workerForm.Show();
                    
                    loginForm.Hide();
                }
                else if (result.Permission==1)
                {
                    BuyerForm buyerForm=new BuyerForm();
                    buyerForm.Show();
                    loginForm.Hide();

                }
                else if (result.Permission == 2)
                {
                    AccountantForm accountantForm=new AccountantForm();
                    accountantForm.Show();
                    loginForm.Hide();
                }
                else if (result.Permission == 3)
                {
                    AdminForm adminForm=new AdminForm();
                    loginForm.Hide();
                    adminForm.Show();
                }

            }
            else
            {
                MessageBox.Show("NIEPOPRAWNY LOGIN LUB HASLO");
            }
        }
    }
}
