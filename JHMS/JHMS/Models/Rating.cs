//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JHMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rating
    {
        public int Id { get; set; }
        public Nullable<int> rate { get; set; }
        public Nullable<int> branchId { get; set; }
        public Nullable<int> bookingId { get; set; }
        public Booking booking { get; set; }
    }
}
