using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Prism.Services;

namespace ClienteSistemaMatricula.ViewModels
{
    public class MyNavigationPageViewModel : BaseViewModel, INavigationAware
    {
    
        public MyNavigationPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {

        }
    }
}
