//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASM.Core.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<short> Quantity { get; set; }
        public Nullable<float> Discount { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public Nullable<bool> Fulfilled { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public Nullable<int> ShipperID { get; set; }
        public Nullable<decimal> Freight { get; set; }
        public Nullable<decimal> SalesTax { get; set; }
        public Nullable<int> ProductID { get; set; }
    
        public virtual Shipper Shipper { get; set; }
        public virtual Product Product { get; set; }
    }
}
