//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTDoan
    {
        public int MaCTDoan { get; set; }
        public int MaDoan { get; set; }
        public int TongCPKS { get; set; }
        public int TongCPPT { get; set; }
        public int TongCPBA { get; set; }
        public Nullable<int> TongCPKhac { get; set; }
        public string GhiChu { get; set; }
    
        public virtual Doan Doan { get; set; }
    }
}
