//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eNarudžba
{
    using System;
    using System.Collections.Generic;
    
    public partial class komentariPice
    {
        public int komentariPiceID { get; set; }
        public string komentarPice { get; set; }
        public int piceID { get; set; }
    
        public virtual Pice Pice { get; set; }
    }
}
