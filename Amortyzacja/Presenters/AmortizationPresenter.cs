using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amortyzacja.Forms;
using Amortyzacja.Models;
using Amortyzacja.Navigaton;
using Amortyzacja.View;

namespace Amortyzacja.Presenters
{
    class AmortizationPresenter
    {
        private IAmortizationView _amortizationView = null;
        private AmortizationModel _amortizationModel = null;
        public AmortizationPresenter(IAmortizationView amortizationView)
        {
            _amortizationView = amortizationView;
            _amortizationModel=new AmortizationModel();
           
        }

        public void Pass()
        {
            try
            {
                if (_amortizationView.YearTextBox.Text.Equals("")|| _amortizationView.SerialNumberTextBox.Text.Equals(""))
                {
                    MessageBox.Show("POLE NIE ZOSTAŁO WYPEŁNIONE");
                    return;
                }
                
                int year = int.Parse(_amortizationView.YearTextBox.Text);
                string serialNumber = _amortizationView.SerialNumberTextBox.Text;
                _amortizationModel.Amortization(serialNumber,year);
               


            }
            catch (FormatException formatException)
            {
                MessageBox.Show("ŹLE WYPEŁNIONE POLE");
            }
            
            
        }

        public void LastForm()
        {
            Navigator.GetInstance().Navigate((AmortizationForm)_amortizationView,new AccountantForm());

        }
    }
}
