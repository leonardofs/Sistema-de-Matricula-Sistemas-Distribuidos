using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Models;

namespace Sistema_de_Matricula.Data
{ 
    public class MatriculaContext : DbContext
    {


        //todo terá que ser feito as entidades relacionais de n para n
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Materia> Materias { get; set; }
        //public DbSet<AlunosTurma> Sala { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var conexao = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
            string conexao = "Data Source=DESKTOP-KA7UH2C;Initial Catalog=SistemaMatricula;Persist Security Info=True;User ID=sa;Password=123";
            optionsBuilder.UseSqlServer(conexao);
            base.OnConfiguring(optionsBuilder);
        }

      //  protected override void OnModelCreating(ModelBuilder modelBuilder)
       // {

            //  modelBuilder.Entity<AlunosTurma>().HasKey(alut => new { alut.TurmaID, alut.AlunoID });
           // base.OnModelCreating(modelBuilder);
        //}
    }
}
