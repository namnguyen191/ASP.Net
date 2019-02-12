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
    
    public partial class Patient
    {
        public Patient()
        {
            this.Appointments = new HashSet<Appointment>();
            this.Emergency_Contact = new HashSet<Emergency_Contact>();
        }
    
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone_No { get; set; }
        public Nullable<System.DateTime> Date_Of_Birth { get; set; }
        public string Gender { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public string Address { get; set; }
    
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Emergency_Contact> Emergency_Contact { get; set; }
    }
}
