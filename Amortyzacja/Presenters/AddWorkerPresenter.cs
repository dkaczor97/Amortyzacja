using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amortyzacja.View;

namespace Amortyzacja.Presenters
{
    public class AddWorkerPresenter
    {
        private IAddWorkerView _addWorkerView = null;

        public AddWorkerPresenter(IAddWorkerView addWorkerView)
        {
            _addWorkerView = addWorkerView;
        }

    }
}
