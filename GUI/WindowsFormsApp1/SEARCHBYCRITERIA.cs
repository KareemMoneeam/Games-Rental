//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class SEARCHBYCRITERIA
    {
        public decimal CLIENT_ID { get; set; }
        public decimal GAME_ID { get; set; }
        public Nullable<decimal> GID { get; set; }
        public Nullable<decimal> GYEAR { get; set; }
        public string GNAME { get; set; }
        public string PALTFORM { get; set; }
        public string CATEGORY { get; set; }
    
        public virtual CLIENT CLIENT { get; set; }
        public virtual GAME GAME { get; set; }
    }
}
