using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System.Threading.Tasks;

namespace ClienteSistemaMatricula.ViewModels
{
    public class CadastrarMateriaPageViewModel : BaseViewModel
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { SetProperty(ref _nome, value); }
        }

        public DelegateCommand CadastrarButtonCommand { get; set; }

        //////////////////////////////////////CONSTRUTOR////////////////////////////////////////
        public CadastrarMateriaPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            Nome = "";

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
