using System;
using System.Collections.Generic;

using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    [DataContract]
    public class Aluno
    {
        [Key]
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public DateTime Nascimento { get; set; }

        [DataMember]
        public string Sexo { get; set; }


        //todo tratar 1 para n
      //  [IgnoreDataMember]
        //public virtual Curso Cursos { get; set; } //navigation

       // [DataMember]
       // public int CursoID { get; set; }

       // [IgnoreDataMember]
       // public virtual IList<AlunosTurma> AlunosTurmas { get; set; }//navigation

    }
}
