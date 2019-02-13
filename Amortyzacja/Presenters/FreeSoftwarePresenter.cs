using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amortyzacja.Navigaton;
using Amortyzacja.View;

namespace Amortyzacja.Presenters
{
    class FreeSoftwarePresenter
    {
        private IFreeSoftwareView _freeSoftwareView = null;
        public FreeSoftwarePresenter(IFreeSoftwareView freeSoftwareView)
        {
            _freeSoftwareView = freeSoftwareView;
        }
        public void LastForm()
        {
            Navigator.GetInstance().NavigateBack();
        }
    }
}
