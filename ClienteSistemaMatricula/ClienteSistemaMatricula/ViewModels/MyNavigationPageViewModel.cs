using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace ClienteSistemaMatricula.ViewModels
{
    public class MyNavigationPageViewModel : BaseViewModel, INavigationAware
    {
    
        public MyNavigationPageViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
    }
}
