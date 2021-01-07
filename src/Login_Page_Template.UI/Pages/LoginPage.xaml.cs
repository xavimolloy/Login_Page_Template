using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Login_Page_Template.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login_Page_Template.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : MvxContentPage<LoginViewModel>
    {
        public  LoginPage()
        {
            InitializeComponent();
        }
    }
}
