﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entidade : DbContext
    {
        public Entidade()
            : base("name=Entidade")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CURSO> CURSO { get; set; }
        public virtual DbSet<DEPARTAMENTO> DEPARTAMENTO { get; set; }
        public virtual DbSet<DISCIPLINA> DISCIPLINA { get; set; }
        public virtual DbSet<DISCIPLINA_CURSO> DISCIPLINA_CURSO { get; set; }
        public virtual DbSet<DISCIPLINA_TURMA> DISCIPLINA_TURMA { get; set; }
        public virtual DbSet<ESPACO> ESPACO { get; set; }
        public virtual DbSet<GRADE> GRADE { get; set; }
        public virtual DbSet<GRADE_TURMA> GRADE_TURMA { get; set; }
        public virtual DbSet<PROFESSOR> PROFESSOR { get; set; }
        public virtual DbSet<SEMESTRE> SEMESTRE { get; set; }
        public virtual DbSet<TURMA> TURMA { get; set; }
    }
}
