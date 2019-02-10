using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amortyzacja.View;

namespace Amortyzacja.Presenter
{
    public class AdminPresenter
    {
        private IAdminView _adminView;

        public AdminPresenter(IAdminView adminView)
        {
            _adminView = adminView;
        }

        public void FreeSoftware()
        {
            IODatabaseEntities db=new IODatabaseEntities();
            db.Softwares.Where(software => software.Workers_IdWorker != null);
        }

        public void OccupiedSoftware()
        {
            IODatabaseEntities db = new IODatabaseEntities();
            db.Softwares.Where(software=>software.Workers_IdWorker==null);


        }

        public void FreeHardware()
        {
            IODatabaseEntities db = new IODatabaseEntities();
            db.Hardwares.Where(hardware => hardware.Workers_IdWorker != null);


        }

        public void OccupiedHardware()
        {
            IODatabaseEntities db = new IODatabaseEntities();
            db.Hardwares.Where(hardware=>hardware.Workers_IdWorker==null);


        }
    }
}
