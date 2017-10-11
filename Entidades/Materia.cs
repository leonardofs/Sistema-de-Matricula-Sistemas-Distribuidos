using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Entidades
{
    [DataContract]
    public class Materia
    {
        [Key]
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public String Nome { get; set; }
    }
}
