﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amortyzacja.View;

namespace Amortyzacja.Presenter
{
    class LoginPresenter
    {
        private ILoginView _loginView;
        private IODatabaseEntities db =new IODatabaseEntities();
        public LoginPresenter(ILoginView loginView)
        {
            _loginView = loginView;
        }

        public bool LoginToApp(string login, string password)
        {
            Workers worker=new Workers(){};

            return true;
        }
    }
}