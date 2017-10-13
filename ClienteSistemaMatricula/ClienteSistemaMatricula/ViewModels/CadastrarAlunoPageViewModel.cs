using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Threading.Tasks;

namespace ClienteSistemaMatricula.ViewModels
{
    public class CadastrarAlunoPageViewModel : BaseViewModel
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

        public DelegateCommand CadastrarButtonCommand { get; set; }

        //////////////////////////////////////CONSTRUTOR////////////////////////////////////////    
        public CadastrarAlunoPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            Nome = "";
            DataNascimento = new DateTime(2000, 1, 1, 0, 00, 0);
            Sexo = "0"; //0==Masculino   1==Feminino

            CadastrarButtonCommand = new DelegateCommand(async () => await ExecuteCadastrarButtonCommand());
        }

        private async Task ExecuteCadastrarButtonCommand()
        {
            if (Nome == "" || Nome.Length <= 3)
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
