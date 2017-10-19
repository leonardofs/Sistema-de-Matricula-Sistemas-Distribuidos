using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Matricula.Models
{
    
    [DataContract]
    public class AlunosTurma
    {
        [IgnoreDataMember]
        public virtual Aluno Aluno { get; set; }//Navigation Propiety
                                                // [ForeignKey("Aluno")]
        [DataMember]
        public int AlunoID { get; set; }

        [IgnoreDataMember]
        public virtual Turma Turma { get; set; }//Navigation Propiety
                                                // [ForeignKey("Turma")]
        [DataMember]
        public int TurmaID { get; set; }
    }
}

