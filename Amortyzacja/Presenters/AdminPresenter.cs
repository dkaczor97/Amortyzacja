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
    public class AdminPresenter
    {
        private IAdminView _adminView;
        DatabaseEntities db=new DatabaseEntities();

        public AdminPresenter(IAdminView adminView)
        {
            _adminView = adminView;
        }

        public void FreeSoftware()
        {
            Navigator.GetInstance().Navigate((Form)_adminView,new FreeSoftwareForm());
        }

       
        public void OccupiedSoftware()
        {
            Navigator.GetInstance().Navigate((Form)_adminView,new OccupiedSoftwareForm());
        }

        public void FreeHardware()
        {
            Navigator.GetInstance().Navigate((Form)_adminView,new FreeHardwareForm());
        }

        public void OccupiedHardware()
        {
            Navigator.GetInstance().Navigate((Form)_adminView,new OccupiedHardwareForm());
        }

        public void TaxPerPeriod()
        { 

        }

        public void AssetsCosts()
        {

        }

        public void RegisterSoftware()
        {
            Navigator.GetInstance().Navigate((Form)_adminView,new RegisterAssetsForm(EAssets.Software));
        }

        public void RegisterHardware()
        {
            Navigator.GetInstance().Navigate((Form)_adminView, new RegisterAssetsForm(EAssets.Hardware));
        }

        public void Logout()
        {
            Navigator.GetInstance().Navigate((Form)_adminView,new LoginForm());
        }
    }
}
