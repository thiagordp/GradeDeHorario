//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class GRADE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GRADE()
        {
            this.DISCIPLINA_TURMA = new HashSet<DISCIPLINA_TURMA>();
        }
    
        public int SEQ_GRADE { get; set; }
        public Nullable<int> DIA_SEMANA_GRADE { get; set; }
        public Nullable<int> HORARIO_GRADE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DISCIPLINA_TURMA> DISCIPLINA_TURMA { get; set; }
    }
}
