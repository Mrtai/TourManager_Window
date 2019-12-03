﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL_TOUR
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_TOUREntities : DbContext
    {
        public DB_TOUREntities(string connectionString) : base("name=DB_TOUREntities")
        {
            //data source = MR_TAI1\SQLEXPRESS; initial catalog = DB_TOUR; user id = sa; password = sa2012; MultipleActiveResultSets = True; App = EntityFramework
            string[] parts = connectionString.Split(';');
            string dataSourcestr = "";
            string database = "";
            string user = "";
            string password = "";
            bool c = false;
            for (int i = 0; i < parts.Length; i++)
            {
                string part = parts[i].Trim();
                if (part.StartsWith("provider connection string="))
                {
                    dataSourcestr = part.Replace("provider connection string=", "");
                }
                if (part.StartsWith("data source="))
                {
                    dataSourcestr = part.Replace("data source=", "");
                    c = true;
                }
                if (part.StartsWith("initial catalog="))
                {
                    database = part.Replace("initial catalog=", "");
                }
                if (part.StartsWith("user id="))
                {
                    user = part.Replace("user id=", "");
                }
                if (part.StartsWith("password="))
                {
                    password = part.Replace("password=", "");
                }

            }
            string datasource = "";
            if (c)
            {
                datasource = dataSourcestr;
            }
            else
            {
                string[] partpass = dataSourcestr.Split('=');
                datasource = partpass[1].Trim();
            }
            string dbconnect = "data source =" + datasource + "; initial catalog =" + database + "; user id =" + user + "; password =" + password + "; MultipleActiveResultSets = True; App = EntityFramework";
            this.Database.Connection.ConnectionString = dbconnect;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<DIA_DIEM_DU_LICH> DIA_DIEM_DU_LICH { get; set; }
        public DbSet<DICH_VU> DICH_VU { get; set; }
        public DbSet<KHACH_HANG> KHACH_HANG { get; set; }
        public DbSet<KHACH_SAN> KHACH_SAN { get; set; }
        public DbSet<LICH_KHOI_HANH> LICH_KHOI_HANH { get; set; }
        public DbSet<LOAI_TOUR> LOAI_TOUR { get; set; }
        public DbSet<MAN_HINH> MAN_HINH { get; set; }
        public DbSet<NHAN_VIEN> NHAN_VIEN { get; set; }
        public DbSet<NHAN_VIEN_NHOM> NHAN_VIEN_NHOM { get; set; }
        public DbSet<NHOM> NHOMs { get; set; }
        public DbSet<PHAN_QUYEN> PHAN_QUYEN { get; set; }
        public DbSet<TINH> TINHs { get; set; }
        public DbSet<TOUR> TOURs { get; set; }
        public DbSet<CHUONG_TRINH_TOUR> CHUONG_TRINH_TOUR { get; set; }
        public DbSet<DANH_SACH_DICH_VU> DANH_SACH_DICH_VU { get; set; }
        public DbSet<LOAI_THANH_TOAN> LOAI_THANH_TOAN { get; set; }
        public DbSet<TOUR_DAT> TOUR_DAT { get; set; }
    }
}
