using Microsoft.EntityFrameworkCore;
using Sistema_de_Matricula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Matricula
{
    class SistemaMatriculaContext:DbContext
    {


        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<AlunosTurma> Sala { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conexao = "Data Source=LeonardoFS ;Initial Catalog=SistemaMatricula;Persist Security Info=True;User ID=sa;Password=123";
            optionsBuilder.UseSqlServer(conexao);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<AlunosTurma>().HasKey(alut => new { alut.TurmaID, alut.AlunoID });
            base.OnModelCreating(modelBuilder);
        }
    }
}
