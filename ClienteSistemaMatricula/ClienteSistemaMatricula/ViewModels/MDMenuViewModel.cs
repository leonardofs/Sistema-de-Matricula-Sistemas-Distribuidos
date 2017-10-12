using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Navigation;
using Prism.Services;
using System.Diagnostics;
using Prism.Unity;
using Xamarin.Forms;
using ClienteSistemaMatricula.Views;

namespace ClienteSistemaMatricula.ViewModels
{
    public class MDMenuViewModel : BaseViewModel, INavigationAware
    {
      
        public DelegateCommand AlunosCommand { get; set; }
        public DelegateCommand ProfessoresCommand { get; set; }
        public DelegateCommand CursosCommand { get; set; }
        public DelegateCommand MateriasCommand { get; set; }
        public DelegateCommand TurmasCommand { get; set; }

        public MDMenuViewModel(INavigationService navigationService): base(navigationService)
        {
            //todo navegation   

            //   AlunosCommand = new DelegateCommand(async () => await ExecuteAlunosCommand());
            AlunosCommand = new DelegateCommand(async () => await ExecuteAlunosCommand());
            ProfessoresCommand = new DelegateCommand(async () => await ExecuteProfessoresCommand());
            CursosCommand = new DelegateCommand(async () => await ExecuteCursosCommand());
            MateriasCommand = new DelegateCommand(async () => await ExecuteMateriasCommand());
            TurmasCommand = new DelegateCommand(async () => await ExecuteTurmasCommand());
        }

        private async Task ExecuteAlunosCommand()
        {
            await _navigationService.NavigateAsync("MyNavigationPage/CadastrarAlunoPage", useModalNavigation: false);

        }

        private async Task ExecuteProfessoresCommand()
        {
            await _navigationService.NavigateAsync("MyNavigationPage/ProfessoresPage", useModalNavigation: false);        }

        private async Task ExecuteCursosCommand()
        {
            await _navigationService.NavigateAsync("MyNavigationPage/CursosPage", useModalNavigation: false);
        }

        private async Task ExecuteMateriasCommand()
        {
            await _navigationService.NavigateAsync("MyNavigationPage/MateriasPage", useModalNavigation: false);
        }

        private async Task ExecuteTurmasCommand()
        {
            await _navigationService.NavigateAsync("MyNavigationPage/TurmasPage", useModalNavigation: false);
        }
    }
}
