﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjBookStore
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbPlusNEntities : DbContext
    {
        public dbPlusNEntities()
            : base("name=dbPlusNEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tAuthor> tAuthor { get; set; }
        public virtual DbSet<tBook> tBook { get; set; }
        public virtual DbSet<tCatagory> tCatagory { get; set; }
        public virtual DbSet<tCategory> tCategory { get; set; }
        public virtual DbSet<tCompany> tCompany { get; set; }
        public virtual DbSet<tCustomerLevel> tCustomerLevel { get; set; }
        public virtual DbSet<tCustomerLike> tCustomerLike { get; set; }
        public virtual DbSet<tCustomerService> tCustomerService { get; set; }
        public virtual DbSet<tCustomerWatchList> tCustomerWatchList { get; set; }
        public virtual DbSet<tDepartments> tDepartments { get; set; }
        public virtual DbSet<tDiscount> tDiscount { get; set; }
        public virtual DbSet<tEmployee> tEmployee { get; set; }
        public virtual DbSet<tEvent> tEvent { get; set; }
        public virtual DbSet<tExpenseCategories> tExpenseCategories { get; set; }
        public virtual DbSet<tExpenseItems> tExpenseItems { get; set; }
        public virtual DbSet<tExpenseReports> tExpenseReports { get; set; }
        public virtual DbSet<tFundrasing> tFundrasing { get; set; }
        public virtual DbSet<tFundrasingPlan> tFundrasingPlan { get; set; }
        public virtual DbSet<tMember> tMember { get; set; }
        public virtual DbSet<tMerchandise> tMerchandise { get; set; }
        public virtual DbSet<tOrders> tOrders { get; set; }
        public virtual DbSet<tPosition> tPosition { get; set; }
        public virtual DbSet<tProblem> tProblem { get; set; }
        public virtual DbSet<tProducts> tProducts { get; set; }
        public virtual DbSet<tCard> tCard { get; set; }
    }
}