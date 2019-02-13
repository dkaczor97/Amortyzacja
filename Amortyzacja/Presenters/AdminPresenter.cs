using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
        }

       
        public void OccupiedSoftware()
        {
            
            


        }

        public void FreeHardware()
        {
            
            


        }

        public void OccupiedHardware()
        {
            


        }

        public void Logout()
        {
            Navigator.GetInstance().NavigateBack();
        }
    }
}
