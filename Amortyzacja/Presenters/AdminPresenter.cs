using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amortyzacja.Forms;
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
            
            db.Softwares.Where(software=>software.Workers_IdWorker==null);


        }

        public void FreeHardware()
        {
            
            db.Hardwares.Where(hardware => hardware.Workers_IdWorker != null);


        }

        public void OccupiedHardware()
        {
            DatabaseEntities db = new DatabaseEntities();
            db.Hardwares.Where(hardware=>hardware.Workers_IdWorker==null);


        }

        public void Logout()
        {
            LoginForm loginForm=new LoginForm();
            LoginPresenter loginPresenter=new LoginPresenter(loginForm);
            (_adminView as AdminForm).Hide();
            loginForm.Show();
        }
    }
}
