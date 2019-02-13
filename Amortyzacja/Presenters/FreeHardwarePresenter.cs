using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amortyzacja.Navigaton;
using Amortyzacja.View;

namespace Amortyzacja.Presenters
{
    class FreeHardwarePresenter
    {
        private IFreeHardwareView _freeHardwareView = null;
        public FreeHardwarePresenter(IFreeHardwareView freeHardwareView)
        {
            _freeHardwareView = freeHardwareView;
        }
        public void LastForm()
        {
            Navigator.GetInstance().NavigateBack();
        }
    }
}
