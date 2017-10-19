using System;

using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_de_Matricula.Models
{
    [DataContract]
    public class Professor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public string Sexo { get; set; }

        [DataMember]
        public int Registro { get; set; }

        [DataMember]
        public string GrauAcademico { get; set; }

        [IgnoreDataMember]
        public IList<Turma> Turmas { get; set; }

    }

}
