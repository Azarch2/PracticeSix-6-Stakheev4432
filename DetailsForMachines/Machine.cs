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
    using System.Collections.Generic;
    
    public partial class Machine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Machine()
        {
            this.Detail = new HashSet<Detail>();
        }
    
        public int Id { get; set; }
        public string Number { get; set; }
        public string Model { get; set; }
        public int TypeId { get; set; }
        public System.DateTime StartWorkDate { get; set; }
        public string ServiceLife { get; set; }
        public System.DateTime WriteOffDate { get; set; }
        public int WorkerId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detail> Detail { get; set; }
        public virtual TypeOfMachine TypeOfMachine { get; set; }
        public virtual Worker Worker { get; set; }
    }
}