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
        public void FreeSoftware()
        {
            db.Softwares.Where(software => software.Workers_IdWorker != null);
        }
    }
}
