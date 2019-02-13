using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amortyzacja.Forms;
using Amortyzacja.Navigaton;
using Amortyzacja.View;

namespace Amortyzacja.Presenters
{
    class AmortizationPresenter
    {
        private IAmortizationView _amortizationView = null;
        public AmortizationPresenter(IAmortizationView amortizationView)
        {
            _amortizationView = amortizationView;
        }

        public void LastForm()
        {
            Navigator.GetInstance().Navigate((AmortizationForm)_amortizationView,new AccountantForm());

        }
    }
}
