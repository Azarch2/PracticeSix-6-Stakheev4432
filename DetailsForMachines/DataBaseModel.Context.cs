//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DetailsForMachines
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MachinesAndDetailsEntities : DbContext
    {
        public MachinesAndDetailsEntities()
            : base("name=MachinesAndDetailsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DeliveryNote> DeliveryNote { get; set; }
        public virtual DbSet<Detail> Detail { get; set; }
        public virtual DbSet<Machine> Machine { get; set; }
        public virtual DbSet<Storage> Storage { get; set; }
        public virtual DbSet<TypeOfMachine> TypeOfMachine { get; set; }
        public virtual DbSet<Worker> Worker { get; set; }
    }
}
