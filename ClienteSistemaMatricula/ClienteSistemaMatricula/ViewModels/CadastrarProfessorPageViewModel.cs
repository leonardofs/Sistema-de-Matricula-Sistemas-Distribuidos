using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Threading.Tasks;

namespace ClienteSistemaMatricula.ViewModels
{
    public class CadastrarProfessorPageViewModel : BaseViewModel
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

        private string _registro;
        public string Registro
        {
            get { return _registro; }
            set { SetProperty(ref _registro, value); }
        }

        private string _grauAcademico;
        public string GrauAcademico
        {
            get { return _grauAcademico; }
            set { SetProperty(ref _grauAcademico, value); }
        }

        public DelegateCommand CadastrarButtonCommand { get; set; }

        //////////////////////////////////////CONSTRUTOR////////////////////////////////////////    
        public CadastrarProfessorPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            Nome = "";
            DataNascimento = new DateTime(2000, 1, 1);
            Sexo = "0"; //0==Masculino   1==Feminino
            Registro = "";
            GrauAcademico = "0"; //0==Graguado   1==Pós-Graduado   2==Mestre   3==Doutor   4==Pós-Doutor

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
