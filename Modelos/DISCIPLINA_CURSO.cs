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
    
    public partial class DISCIPLINA_CURSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DISCIPLINA_CURSO()
        {
            this.DISCIPLINA_TURMA = new HashSet<DISCIPLINA_TURMA>();
        }
    
        public string CODIGO_DISCIPLINA { get; set; }
        public int CODIGO_CURSO { get; set; }
        public string CODIGO_TURMA { get; set; }
        public Nullable<int> FASE_DISCIPLINA_CURSO { get; set; }
    
        public virtual CURSO CURSO { get; set; }
        public virtual DISCIPLINA DISCIPLINA { get; set; }
        public virtual TURMA TURMA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DISCIPLINA_TURMA> DISCIPLINA_TURMA { get; set; }
    }
}
