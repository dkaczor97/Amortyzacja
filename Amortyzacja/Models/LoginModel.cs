using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amortyzacja.Models
{
    public class LoginModel
    {
        IODatabaseEntities db;

        public LoginModel()
        {
            db = new IODatabaseEntities();
        }

        public Account GetAccount(string login, string password)
        {
            return db.Accounts.FirstOrDefault(account => account.UserLogin == login && account.UserPassword == password);
        }
    }
}
