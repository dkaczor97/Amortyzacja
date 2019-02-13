using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amortyzacja.Navigaton;
using Amortyzacja.View;

namespace Amortyzacja.Presenters
{
    class OccupiedSoftwarePresenter
    {
        private IOccupiedSoftwareView _occupiedSoftwareView = null;
        public OccupiedSoftwarePresenter(IOccupiedSoftwareView occupiedSoftwareView)
        {
            _occupiedSoftwareView = occupiedSoftwareView;
        }
        public void LastForm()
        {
            Navigator.GetInstance().NavigateBack();
        }
    }
}
