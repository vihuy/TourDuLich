
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
    
public partial class ThoiGianDoan
{

    public int MaThoiGianDoan { get; set; }

    public int MaDoan { get; set; }

    public Nullable<System.DateTime> NgayDi { get; set; }

    public Nullable<System.DateTime> NgayVe { get; set; }

    public Nullable<bool> TrangThai { get; set; }



    public virtual Doan Doan { get; set; }

}

}
