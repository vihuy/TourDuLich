﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TourDuLichEntities : DbContext
    {
        public TourDuLichEntities()
            : base("name=TourDuLichEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<CTDoan> CTDoans { get; set; }
        public virtual DbSet<DangKi> DangKis { get; set; }
        public virtual DbSet<DiaDiem> DiaDiems { get; set; }
        public virtual DbSet<Doan> Doans { get; set; }
        public virtual DbSet<Doan_ChiPhiKhac> Doan_ChiPhiKhac { get; set; }
        public virtual DbSet<Doan_DiaDiem> Doan_DiaDiem { get; set; }
        public virtual DbSet<Doan_KhachSan> Doan_KhachSan { get; set; }
        public virtual DbSet<Doan_PhuongTien> Doan_PhuongTien { get; set; }
        public virtual DbSet<Doan_QuanAn> Doan_QuanAn { get; set; }
        public virtual DbSet<Gia> Gias { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiHinhDL> LoaiHinhDLs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhanCong> PhanCongs { get; set; }
        public virtual DbSet<ThoiGianDoan> ThoiGianDoans { get; set; }
        public virtual DbSet<TinhThanh> TinhThanhs { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }
        public virtual DbSet<Tour_Gia> Tour_Gia { get; set; }
    }
}
