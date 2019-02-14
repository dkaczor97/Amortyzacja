using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amortyzacja.Enums;
using Amortyzacja.Forms;
using Amortyzacja.Navigaton;
using Amortyzacja.View;

namespace Amortyzacja.Presenter
{
    public class BuyerPresenter
    {
        private IBuyerView _buyerView;

        public BuyerPresenter(IBuyerView buyerView)
        {
            _buyerView = buyerView;
        }
        public void AddSoftware()
        {

        }

        public void AddHardware()
        {

        }

        public void RegisterSoftware()
        {
            Navigator.GetInstance().Navigate((Form)_buyerView, new RegisterAssetsForm(EAssets.Software));

        }

        public void RegisterHardware()
        {
            Navigator.GetInstance().Navigate((Form)_buyerView, new RegisterAssetsForm(EAssets.Hardware));
        }

        public void Logout()
        {
            Navigator.GetInstance().Navigate((Form)_buyerView, new LoginForm());
        }

        public void FreeSoftware()
        {

        }

        public void FreeHardware()
        {

        }
    }
}
