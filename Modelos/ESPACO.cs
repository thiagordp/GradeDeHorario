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
    
    public partial class ESPACO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESPACO()
        {
            this.DISCIPLINA_TURMA = new HashSet<DISCIPLINA_TURMA>();
        }
    
        public string CODIGO_ESPACO { get; set; }
        public Nullable<bool> QUADRO_VIDRO_ESPACO { get; set; }
        public Nullable<bool> PROJETOR_ESPACO { get; set; }
        public Nullable<bool> INTERNET_ESPACO { get; set; }
        public Nullable<int> CAPACIDADE_ESPACO { get; set; }
        public Nullable<bool> QUADRO_BRANCO_ESPACO { get; set; }
        public Nullable<int> TIPO_ESPACO { get; set; }
        public Nullable<int> NUMERO_PC_ESPACO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DISCIPLINA_TURMA> DISCIPLINA_TURMA { get; set; }
    }
}
