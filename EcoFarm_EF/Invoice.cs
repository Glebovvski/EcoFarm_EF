//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcoFarm_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        public int Invoice_number { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> Supplier_code { get; set; }
        public Nullable<int> Invoice_type { get; set; }
        public string Supplier { get; set; }
        public string Reciever { get; set; }
    }
}
