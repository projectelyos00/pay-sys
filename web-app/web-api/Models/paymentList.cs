//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace web_api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class paymentList
    {
        public int pL_Id { get; set; }
        public Nullable<System.DateTime> pL_Date { get; set; }
        public Nullable<int> pL_Amount { get; set; }
        public string pL_Status { get; set; }
        public int aB_Id { get; set; }
    
        public virtual accountBalance accountBalance { get; set; }
    }
}
