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
    
    public partial class DISCIPLINA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DISCIPLINA()
        {
            this.DISCIPLINA_CURSO = new HashSet<DISCIPLINA_CURSO>();
            this.DISCIPLINA1 = new HashSet<DISCIPLINA>();
            this.DISCIPLINA2 = new HashSet<DISCIPLINA>();
        }
    
        public string CODIGO_DISCIPLINA { get; set; }
        public Nullable<int> CREDITO_DISCIPLINA { get; set; }
        public string NOME_DISCIPLINA { get; set; }
        public Nullable<int> CODIGO_DEPARTAMENTO { get; set; }
    
        public virtual DEPARTAMENTO DEPARTAMENTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DISCIPLINA_CURSO> DISCIPLINA_CURSO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DISCIPLINA> DISCIPLINA1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DISCIPLINA> DISCIPLINA2 { get; set; }
    }
}
