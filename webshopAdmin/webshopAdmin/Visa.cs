//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webshopAdmin
{
    using System;
    using System.Collections.Generic;
    
    public partial class Visa
    {
        public int id { get; set; }
        public Nullable<int> UserProfile { get; set; }
        public string visainfo { get; set; }
    
        public virtual UserProfile UserProfile1 { get; set; }
    }
}