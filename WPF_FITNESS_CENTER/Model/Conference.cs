//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_FITNESS_CENTER.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Conference
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Conference()
        {
            this.Participant = new HashSet<Participant>();
        }
    
        public int ID_conference { get; set; }
        public string Name_conference { get; set; }
        public int ID_coach { get; set; }
        public int ID_Moderator { get; set; }
        public int ID_Organizator { get; set; }
    
        public virtual Coach Coach { get; set; }
        public virtual Moderator Moderator { get; set; }
        public virtual Organizator Organizator { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Participant> Participant { get; set; }
    }
}