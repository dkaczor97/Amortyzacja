using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amortyzacja.Models
{
    class AdminModel
    {
        DatabaseEntities db=new DatabaseEntities();
        public IQueryable<Software> FreeSoftware()
        {
            return db.Softwares.Where(software => software.Workers_IdWorker == null);
        }

        public IQueryable<Software> OccupiedSoftware()
        {
            return db.Softwares.Where(software => software.Workers_IdWorker != null);
        }

        public IQueryable<Hardware> FreeHardware()
        {
            return db.Hardwares.Where(hardware=>hardware.Workers_IdWorker==null);
        }

        public IQueryable<Hardware> OccupiedHardware()
        {
            return db.Hardwares.Where(hardware => hardware.Workers_IdWorker != null);
        }
    }
}
