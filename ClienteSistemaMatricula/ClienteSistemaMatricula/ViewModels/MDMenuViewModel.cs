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
    public class MDMenuViewModel : BaseViewModel, INavigatedAware
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
            AlunosCommand = new DelegateCommand(ExecuteAlunosCommand);
            ProfessoresCommand = new DelegateCommand(ExecuteProfessoresCommand);
            CursosCommand = new DelegateCommand(ExecuteCursosCommand);
            MateriasCommand = new DelegateCommand(ExecuteMateriasCommand);
            TurmasCommand = new DelegateCommand(ExecuteTurmasCommand);
        }

        private void ExecuteAlunosCommand()
        {
            (Application.Current.MainPage as MasterDetailPage).Detail = new  NavigationPage((Page)Activator.CreateInstance(typeof(AlunosPage)));
            
        }

        private void ExecuteProfessoresCommand()
        {
            (Application.Current.MainPage as MasterDetailPage).Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ProfessoresPage)));
        }

        private void ExecuteCursosCommand()
        {
            (Application.Current.MainPage as MasterDetailPage).Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(CursosPage)));
        }

        private void ExecuteMateriasCommand()
        {
            (Application.Current.MainPage as MasterDetailPage).Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(MateriasPage)));
        }

        private void ExecuteTurmasCommand()
        {
            (Application.Current.MainPage as MasterDetailPage).Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(TurmasPage)));
        }
    }
}
