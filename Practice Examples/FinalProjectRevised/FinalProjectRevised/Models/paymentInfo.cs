//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProjectRevised.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class paymentInfo
    {
        public paymentInfo()
        {
            this.orders = new HashSet<order>();
        }
    
        public int Id { get; set; }
        public Nullable<int> custId { get; set; }
        public string type { get; set; }
        public string cardNo { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual ICollection<order> orders { get; set; }
    }
}
