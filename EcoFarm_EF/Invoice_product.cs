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
    
    public partial class Invoice_product
    {
        public int Product_code { get; set; }
        public string Name { get; set; }
        public string Units { get; set; }
        public double Number_of_units { get; set; }
        public double Unit_price { get; set; }
        public double Total_price { get; set; }
        public int Invoice_Number { get; set; }
    }
}
