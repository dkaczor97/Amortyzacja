using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amortyzacja.Models
{
    class OccupiedSoftwareModel
    {
        DatabaseEntities db=new DatabaseEntities();
        public void OccupiedSoftware(ListView occupiedHardware)
        {
            string[] elemTab = new string[3];

            IQueryable<Software> collection = db.Softwares.Where(software => software.Worker != null);
            foreach (Software software in collection)
            {
                string typ = software.SoftwareType;
                string serialNumber = software.SerialNumber;

                elemTab[0] = typ;
                elemTab[1] = serialNumber;


            }

            ListViewItem item = new ListViewItem(elemTab);
            occupiedHardware.Items.Add(item);

        }
    }
}
