using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amortyzacja.Models
{
    class AmortizationModel
    {
        private DatabaseEntities db;

        public AmortizationModel()
        {
            db=new DatabaseEntities();
        }
        public void Amortization(string serialNumber,int year)
        {
            Hardware tmpHardware = db.Hardwares.FirstOrDefault(hardware => hardware.SerialNumber == serialNumber);
            if (tmpHardware == null)
            {
                MessageBox.Show("BŁĘDNY NUMER SERYJNY");
                return;
            }

            if (tmpHardware.Amortization != null)
            {
                MessageBox.Show("SPRZĘT MA JUŻ PRZYPISANĄ AMORTYZACJĘ");
                return;
            }

            Purchase purchase = tmpHardware.Purchase;
            double price = purchase.Price;
            double amortization = price * 0.2 / 12.0;
            string type = tmpHardware.Type;
            DateTime endDate = DateTime.Now.Date.AddYears(year);
            Amortization tmpAmortization = new Amortization() { Type = type, AmortizationAmount = amortization, StartDate = DateTime.Now.Date,EndDate = endDate};
            tmpHardware.Amortization = tmpAmortization;
            db.Amortizations.Add(tmpAmortization);
            db.SaveChanges();
        }

        public IQueryable<Hardware> FindHardware()
        {
            return db.Hardwares.Where(hardware => hardware.Amortization == null);
        }
    }
}
