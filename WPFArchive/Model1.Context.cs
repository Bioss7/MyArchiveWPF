﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFArchive
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbArchiveEntities : DbContext
    {
        public DbArchiveEntities()
            : base("name=DbArchiveEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AcademicLeave> AcademicLeave { get; set; }
        public virtual DbSet<Diploma> Diploma { get; set; }
        public virtual DbSet<Discipline> Discipline { get; set; }
        public virtual DbSet<DisciplineList> DisciplineList { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<GroupStudentNumber> GroupStudentNumber { get; set; }
        public virtual DbSet<OrderList> OrderList { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PersonalDocument> PersonalDocument { get; set; }
        public virtual DbSet<Qualification> Qualification { get; set; }
        public virtual DbSet<Specialty> Specialty { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
