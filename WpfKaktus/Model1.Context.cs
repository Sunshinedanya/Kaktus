﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfKaktus
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KaktusEntities : DbContext
    {
        public KaktusEntities()
            : base("name=KaktusEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Collection> Collection { get; set; }
        public virtual DbSet<Exibition> Exibition { get; set; }
        public virtual DbSet<Kaktus> Kaktus { get; set; }
        public virtual DbSet<KaktusType> KaktusType { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
