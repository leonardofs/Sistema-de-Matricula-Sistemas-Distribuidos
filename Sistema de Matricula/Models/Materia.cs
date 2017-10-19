using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace Sistema_de_Matricula.Models
{
    [DataContract]
    public class Materia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public String Nome { get; set; }

        [IgnoreDataMember]
        public virtual Curso Cursos { get; set; } //navigation

        [DataMember]
        public int CursoID { get; set; }
    }
}
