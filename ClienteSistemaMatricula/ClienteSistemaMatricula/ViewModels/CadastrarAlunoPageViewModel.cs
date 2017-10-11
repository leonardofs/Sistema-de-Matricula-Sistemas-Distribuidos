using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClienteSistemaMatricula.ViewModels
{
    public class CadastrarAlunoPageViewModel : BindableBase
    {

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { SetProperty(ref _nome, value); }
        }

        private DateTime _dataNascimento;
        public DateTime DataNascimento
        {
            get { return _dataNascimento; }
            set { SetProperty(ref _dataNascimento, value); }
        }

        private string _sexo;
        public string Sexo
        {
            get { return _sexo; }
            set { SetProperty(ref _sexo, value); }
        }


        public CadastrarAlunoPageViewModel()
        {

        }
            
    }
    
}
