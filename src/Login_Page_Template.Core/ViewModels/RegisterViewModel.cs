using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MvvmCross.ViewModels;
using MvvmCross.Views;
using Acr.UserDialogs;
using MvvmCross.Navigation;
using Login_Page_Template.Core.Services;
using Firebase.Database;
using Firebase.Database.Query;
using Login_Page_Template.Core.Models;
using Login_Page_Template;
using Xamarin.Forms.Xaml;


namespace Login_Page_Template.Core.ViewModels
{

    public class RegisterViewModel : BaseViewModel
    {


        // public FirebaseHelper firebaseHelper = new FirebaseHelper();
        private string _nombre;
        public string Nombre { get=>_nombre;
            set
            {
                _nombre = value;
                RaisePropertyChanged("Nombre");

            } }

        private string _apellidos;
        public string Apellidos
        {
            get => _apellidos;
            set
            {
                _apellidos = value;
                RaisePropertyChanged("Apellidos");
            }
        }
        private string _email;
        public string Email { get => _email;
            set
            {
                _email = value;
                RaisePropertyChanged("Email");
            }
        }
        private string _contrasenya;
        public string Contrasenya { get=>_contrasenya;
            set
            {
                _contrasenya = value;
                RaisePropertyChanged("Contrasenya");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
       public  void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Command _testButton;

        public Command TestButton =>
            _testButton ?? (_testButton = new Command(SendData));

        public void SendData()
        {
            string toprint = Email + " "+ Nombre + " " + Contrasenya + " " + Apellidos;
            UserDialogs.Instance.Alert(toprint, "Test", "TESTO");
        }
     
    }

}
