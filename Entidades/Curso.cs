using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Entidades
{
    [DataContract]
    public class Curso
    {
        [Key]
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Nome { get; set; }

       // [IgnoreDataMember]
       // public IList<Turma> Turmas { get; set; }//navigation 1 para n com turmas

       // [IgnoreDataMember]
       // public IList<Aluno> Alunos { get; set; }//navigation 1 para n com alunos 
    }
}
