//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CIHHospital.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Emergency_Contact
    {
        public int Id { get; set; }
        public Nullable<int> Patient_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Relationship { get; set; }
        public string Phone_No { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}
