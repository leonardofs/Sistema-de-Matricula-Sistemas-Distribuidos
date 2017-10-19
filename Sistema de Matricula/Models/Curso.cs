using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace Sistema_de_Matricula.Models
{
    [DataContract]
    public class Curso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Nome { get; set; }

        [IgnoreDataMember]
        public IList<Materia> Materias { get; set; }//navigation 1 para n com materias

        [IgnoreDataMember]
        public IList<Aluno> Alunos { get; set; }//navigation 1 para n com alunos 
    }
}
