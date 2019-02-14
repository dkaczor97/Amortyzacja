using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amortyzacja.Models
{
    public class HardwareAdditionModel
    {
        private DatabaseEntities db = null;

        public HardwareAdditionModel()
        {
            db = new DatabaseEntities();
        }
        public bool AddHardware(string hardwareType, string serialNumber, double purchaseValue, DateTime purchaseDate)
        {
            bool result;
            Purchase purchase = new Purchase() { Price = purchaseValue, PurchaseDate = purchaseDate };
            Hardware hardware = new Hardware() { Type = hardwareType, SerialNumber = serialNumber };
            try
            {
                Purchase addedPurchase = db.Purchases.Add(purchase);
                hardware.Purchases_IdPurchase = addedPurchase.IdPurchase;
                db.Hardwares.Add(hardware);
                result = true;
            }
            catch(Exception ex)
            {
                result = false;
            }
            return result;
        }
    }
}
