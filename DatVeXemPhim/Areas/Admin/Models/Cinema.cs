//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatVeXemPhim.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cinema
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cinema()
        {
            this.ShowTimes = new HashSet<ShowTime>();
        }
    
        public int CinId { get; set; }
        public string NameCi { get; set; }
        public string Address { get; set; }
        public Nullable<int> Seats { get; set; }
        public string Phone { get; set; }
        public string Image { get; set; }
        public Nullable<int> Status { get; set; }
        public string ToaDo1 { get; set; }
        public string ToaDo2 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShowTime> ShowTimes { get; set; }
    }
}
