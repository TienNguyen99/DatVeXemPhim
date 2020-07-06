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
    
    public partial class Film
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Film()
        {
            this.Feedbacks = new HashSet<Feedback>();
            this.ShowTimes = new HashSet<ShowTime>();
            this.Slides = new HashSet<Slide>();
        }
    
        public int FilId { get; set; }
        public Nullable<int> TypId { get; set; }
        public Nullable<int> CouId { get; set; }
        public string NameF { get; set; }
        public string Director { get; set; }
        public string Actor { get; set; }
        public Nullable<int> Duration { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public string Picture { get; set; }
        public string PictureBig { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual Country Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual TypeFilm TypeFilm { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShowTime> ShowTimes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Slide> Slides { get; set; }
    }
}
