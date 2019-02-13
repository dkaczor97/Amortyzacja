﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amortyzacja.Enums;
using Amortyzacja.Forms;
using Amortyzacja.Models;
using Amortyzacja.Navigaton;
using Amortyzacja.Presenters;
using Amortyzacja.View;

namespace Amortyzacja.Presenter
{
    public class LoginPresenter
    {
        private ILoginView _loginView;
        private LoginModel _loginModel;
        
        public LoginPresenter(ILoginView loginView)
        {
            _loginView = loginView;
            _loginModel = new LoginModel();
        }

        public void LoginToApp(string login, string password)
        {
            //Account account=new Account(){UserLogin = login,UserPassword = password};
            DatabaseEntities db=new DatabaseEntities();
            Account account = _loginModel.GetAccount(login, password);
            if (account != null)
            {
                Worker worker = account.Worker;
                AppSession.GetInstance().CurrentWorker = worker;
                LoginForm loginForm = _loginView as LoginForm;
                if (account.Permission == (int)EAccountPermission.Worker)
                {
                    WorkerForm workerForm = new WorkerForm();
                    workerForm.Show();
                    loginForm.Hide();
                }
                else if (account.Permission == (int)EAccountPermission.Buyer)
                {
                    BuyerForm buyerForm=new BuyerForm();
                    buyerForm.Show();
                    loginForm.Hide();

                }
                else if (account.Permission == (int)EAccountPermission.Accountant)
                {
                    AccountantForm accountantForm=new AccountantForm();
                    accountantForm.Show();
                    loginForm.Hide();
                }
                else if (account.Permission == (int)EAccountPermission.Admin)
                {
                    
                    Navigator.GetInstance().Navigate((LoginForm)_loginView,new AdminForm());
                }

            }
            else
            {
                MessageBox.Show("NIEPOPRAWNY LOGIN LUB HASLO");
            }
        }
    }
}
