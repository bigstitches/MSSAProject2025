//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBaseCars
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dealership
    {
        public int CarVin { get; set; }
        public int DealerId { get; set; }
        public string Salesmen { get; set; }
        public string Dealership1 { get; set; }
    
        public virtual Car Car { get; set; }
    }
}
