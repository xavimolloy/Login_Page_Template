using System;
using System.Collections.Generic;
using System.Text;
using Login_Page_Template.Core.Services;
using Xamarin.Forms;
using MvvmCross.Binding;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Acr.UserDialogs;
using MvvmCross;
using MvvmCross.Navigation;

namespace Login_Page_Template.Core.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {



        private Command _goToLoginPage;

        public Command GoToLoginPage =>
         _goToLoginPage ?? (_goToLoginPage = new Command(GoToLogin));

        private Command _goToRegisterPage;

        public Command GoToRegisterPage =>
         _goToRegisterPage ?? (_goToRegisterPage = new Command(GoToRegister));

        public void GoToLogin()
        {
            Mvx.IoCProvider.Resolve<IMvxNavigationService>().Navigate<AccessViewModel>();
        }
        public void GoToRegister()
        {
            Mvx.IoCProvider.Resolve<IMvxNavigationService>().Navigate<RegisterViewModel>();

        }

    }
}
