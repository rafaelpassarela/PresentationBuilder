//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PresentationBuilder.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Presentation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Presentation()
        {
            this.PresentationPages = new HashSet<PresentationPage>();
        }
    
        public int PresentationId { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public System.DateTime Date { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PresentationPage> PresentationPages { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
    }
}