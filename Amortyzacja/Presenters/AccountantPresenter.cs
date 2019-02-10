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
    }
}
