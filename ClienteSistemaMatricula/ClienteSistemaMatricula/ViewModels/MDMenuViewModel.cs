using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Navigation;
using Prism.Services;
using System.Diagnostics;

namespace ClienteSistemaMatricula.ViewModels
{
    public class MDMenuViewModel : BindableBase
    {
        public DelegateCommand AlunosCommand { get; set; }
        public DelegateCommand ProfessoresCommand { get; set; }
        public DelegateCommand CursosCommand { get; set; }
        public DelegateCommand MateriasCommand { get; set; }
        public DelegateCommand TurmasCommand { get; set; }

        public MDMenuViewModel()
        {
            AlunosCommand = new DelegateCommand(async () => await ExecuteAlunosCommand());
            ProfessoresCommand = new DelegateCommand(async () => await ExecuteProfessoresCommand());
            CursosCommand = new DelegateCommand(async () => await ExecuteCursosCommand());
            MateriasCommand = new DelegateCommand(async () => await ExecuteMateriasCommand());
            TurmasCommand = new DelegateCommand(async () => await ExecuteTurmasCommand());
        }

        private async Task ExecuteAlunosCommand()
        {


        }

        private async Task ExecuteProfessoresCommand()
        {

        }

        private async Task ExecuteCursosCommand()
        {

        }

        private async Task ExecuteMateriasCommand()
        {

        }

        private async Task ExecuteTurmasCommand()
        {

        }
    }
}
