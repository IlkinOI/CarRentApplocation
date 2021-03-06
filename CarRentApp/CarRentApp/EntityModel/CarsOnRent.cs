//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentApp.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class CarsOnRent
    {
        public int Id { get; set; }
        public Nullable<int> AvailableCarsId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<System.DateTime> RentalDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public Nullable<System.DateTime> AcceptedDate { get; set; }
        public Nullable<int> EditedAddedBy { get; set; }
    
        public virtual AvailableCars AvailableCars { get; set; }
        public virtual Customers Customers { get; set; }
    }
}
