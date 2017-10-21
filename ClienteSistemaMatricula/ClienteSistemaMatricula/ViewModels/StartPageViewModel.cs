using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteSistemaMatricula.ViewModels
{
    public class StartPageViewModel : BaseViewModel
    {
        private string _IPServidor;
        public string IPServidor
        {
            get { return _IPServidor; }
            set { SetProperty(ref _IPServidor, value); }
        }

        public DelegateCommand SalvarButtonCommand { get; set; }

        //////////////////////////////////////CONSTRUTOR////////////////////////////////////////
        public StartPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            IPServidor = "";

            SalvarButtonCommand = new DelegateCommand(async () => await ExecuteSalvarButtonCommand());
        }

        private async Task ExecuteSalvarButtonCommand()
        {
            if (IPServidor.Length < 7)
            {
                await _pageDialogService.DisplayAlertAsync("Erro", "IP inválido!", "OK");
            }
            else
            {
                try
                {
                    //TODO salvar IP
                    await _pageDialogService.DisplayAlertAsync("Sucesso", "IP salvo com sucesso!", "OK");
                    IPServidor = "";
                }
                catch (Exception)
                {
                    await _pageDialogService.DisplayAlertAsync("Erro", "Servidor indisponível!", "OK");
                }
            }
        }
    }
}
