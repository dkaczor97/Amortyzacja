using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amortyzacja.Navigaton;
using Amortyzacja.View;

namespace Amortyzacja.Presenters
{
    class OccupiedHardwarePresenter
    {
        private IOccupiedHardwareView _occupiedHardwareView = null;
        public OccupiedHardwarePresenter(IOccupiedHardwareView occupiedHardwareView)
        {
            _occupiedHardwareView = occupiedHardwareView;
        }
        public void LastForm()
        {
            Navigator.GetInstance().NavigateBack();
        }
    }
}
