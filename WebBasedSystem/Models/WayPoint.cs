//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBasedSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class WayPoint
    {
        public int Id { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public string Suburbs { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }
    }
}