//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PaymentsTrack
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payments
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string UserId { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
