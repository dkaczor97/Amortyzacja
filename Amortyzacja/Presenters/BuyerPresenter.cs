using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amortyzacja.View;

namespace Amortyzacja.Presenter
{
    public class BuyerPresenter
    {
        private IBuyerView _buyerView;

        public BuyerPresenter(IBuyerView buyerView)
        {
            _buyerView = buyerView;
            _buyerView.Presenter = this;
        }
        public void AddSoftware()
        {

        }

        public void AddHardware()
        {

        }

        public void RegisterSoftware()
        {

        }

        public void RegisterHardware()
        {

        }

    }
}
