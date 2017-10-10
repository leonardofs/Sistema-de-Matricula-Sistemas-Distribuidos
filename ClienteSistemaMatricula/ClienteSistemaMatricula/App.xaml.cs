using Prism.Unity;
using ClienteSistemaMatricula.Views;
using Xamarin.Forms;

namespace ClienteSistemaMatricula
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("NavigationPage/MDMenu/MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<MDMenu>();
            Container.RegisterTypeForNavigation<AlunosPage>();
            Container.RegisterTypeForNavigation<CadastrarAlunoPage>();
            Container.RegisterTypeForNavigation<ListarAlunosPage>();
            Container.RegisterTypeForNavigation<ProfessoresPage>();
            Container.RegisterTypeForNavigation<CadastrarProfessorPage>();
            Container.RegisterTypeForNavigation<ListarProfessoresPage>();
            Container.RegisterTypeForNavigation<CursosPage>();
            Container.RegisterTypeForNavigation<CadastrarCursoPage>();
            Container.RegisterTypeForNavigation<ListarCursosPage>();
            Container.RegisterTypeForNavigation<MateriasPage>();
            Container.RegisterTypeForNavigation<CadastrarMateriaPage>();
            Container.RegisterTypeForNavigation<ListarMateriasPage>();
            Container.RegisterTypeForNavigation<TurmasPage>();
            Container.RegisterTypeForNavigation<CadastrarTurmaPage>();
            Container.RegisterTypeForNavigation<ListarTurmasPage>();
        }
    }
}
