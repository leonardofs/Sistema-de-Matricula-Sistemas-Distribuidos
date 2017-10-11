using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
        [DataContract]
        public class Professor
        {
        [Key]
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

        }

}
