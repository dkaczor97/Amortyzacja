//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Amortyzacja
{
    using System;
    using System.Collections.Generic;
    
    public partial class Purchases
    {
        public int IdPurchase { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<int> Hardware_IdHardware { get; set; }
    
        public virtual Hardware Hardware { get; set; }
    }
}