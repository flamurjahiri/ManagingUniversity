//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjektiOrari.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class chatUser
    {
        public int cu_id { get; set; }
        public int chat_id { get; set; }
        public int user_id_from { get; set; }
        public int user_id_to { get; set; }
        public int ip_user { get; set; }
    
        public virtual chat chat { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
