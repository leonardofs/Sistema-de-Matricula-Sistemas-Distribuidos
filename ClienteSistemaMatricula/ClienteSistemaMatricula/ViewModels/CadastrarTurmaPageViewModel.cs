﻿using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System.Threading.Tasks;

namespace ClienteSistemaMatricula.ViewModels
{
    public class CadastrarTurmaPageViewModel : BaseViewModel
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { SetProperty(ref _nome, value); }
        }

        private string _CursoID;
        public string CursoID
        {
            get { return _CursoID; }
            set { SetProperty(ref _CursoID, value); }
        }

        public DelegateCommand CadastrarButtonCommand { get; set; }

        //////////////////////////////////////CONSTRUTOR////////////////////////////////////////
        public CadastrarTurmaPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            Nome = "";
            CursoID = "";
            CadastrarButtonCommand = new DelegateCommand(async () => await ExecuteCadastrarButtonCommand());
        }

        private async Task ExecuteCadastrarButtonCommand()
        {
            if (Nome.Length <= 3)
            {
                await _pageDialogService.DisplayAlertAsync("Erro", "Nome inválido", "OK");
            }
            else
            {
                //TODO inserir no banco
                await _pageDialogService.DisplayAlertAsync("Sucesso", "Cadastrado com sucesso", "OK");
                Nome = "";                
            }
        }
    }
}
