//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBasedSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SpecialistType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SpecialistType()
        {
            this.Specialists = new HashSet<Specialist>();
            this.SpecialistTypeSubMenus = new HashSet<SpecialistTypeSubMenu>();
        }
    
        public int SpecialistTypeId { get; set; }
        public string SpecialistTypeName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specialist> Specialists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialistTypeSubMenu> SpecialistTypeSubMenus { get; set; }
    }
}
