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
    
    public partial class DISCIPLINA_TURMA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DISCIPLINA_TURMA()
        {
            this.ESPACO = new HashSet<ESPACO>();
            this.GRADE = new HashSet<GRADE>();
        }
    
        public int SEQ_TURMA { get; set; }
        public int SEQ_DISCIPLINA_CURSO { get; set; }
        public Nullable<int> CODIGO_PROFESSOR1 { get; set; }
        public Nullable<int> CODIGO_PROFESSOR2 { get; set; }
        public Nullable<int> CODIGO_PROFESSOR3 { get; set; }
    
        public virtual DISCIPLINA_CURSO DISCIPLINA_CURSO { get; set; }
        public virtual PROFESSOR PROFESSOR { get; set; }
        public virtual PROFESSOR PROFESSOR1 { get; set; }
        public virtual PROFESSOR PROFESSOR2 { get; set; }
        public virtual TURMA TURMA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESPACO> ESPACO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRADE> GRADE { get; set; }
    }
}
