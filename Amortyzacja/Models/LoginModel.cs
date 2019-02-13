using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amortyzacja.Models
{
    public class LoginModel
    {
        DatabaseEntities db;

        public LoginModel()
        {
            db = new DatabaseEntities();
        }

        public Account GetAccount(string login, string password)
        {
            return db.Accounts.FirstOrDefault(account => account.UserLogin == login && account.UserPassword == password);
        }
    }
}
