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
    
    public partial class KerkesaPerNderrim
    {
        public int idKerkesa { get; set; }
        public Nullable<int> Lenda { get; set; }
        public System.TimeSpan OraFillimit { get; set; }
        public System.TimeSpan OraMbarimit { get; set; }
        public string Dita { get; set; }
        public Nullable<bool> approved { get; set; }
    }
}
