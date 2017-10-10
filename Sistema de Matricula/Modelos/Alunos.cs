using System;
using System.Collections.Generic;

using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Sistema_de_Matricula.Modelos
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
        public string Sexo { get; set; }

        [DataMember]
        public int Matricula { get; set; }

        //todo tratar 1 para n
      //  [IgnoreDataMember]
        //public virtual Curso Cursos { get; set; } //navigation

       // [DataMember]
       // public int CursoID { get; set; }

       // [IgnoreDataMember]
       // public virtual IList<AlunosTurma> AlunosTurmas { get; set; }//navigation

    }
}
