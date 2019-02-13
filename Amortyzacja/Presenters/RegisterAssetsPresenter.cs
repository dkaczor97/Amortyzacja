using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amortyzacja.Navigaton;
using Amortyzacja.View;

namespace Amortyzacja.Presenters
{
    class RegisterAssetsPresenter
    {
        private IRegisterAssetsView _registerAssetsView = null;
        public RegisterAssetsPresenter(IRegisterAssetsView registerAssetsView)
        {
            _registerAssetsView = registerAssetsView;
        }

        public void LastForm()
        {
            Navigator.GetInstance().NavigateBack();
        }
    }
}
