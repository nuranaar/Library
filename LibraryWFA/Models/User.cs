//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryWFA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.BookReserves = new HashSet<BookReserve>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserUniqueId { get; set; }
        public Nullable<int> CreatedAdmin { get; set; }
    
        public virtual Admin Admin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookReserve> BookReserves { get; set; }
    }
}
