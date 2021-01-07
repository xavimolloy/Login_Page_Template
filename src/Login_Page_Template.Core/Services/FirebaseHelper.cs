using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using Login_Page_Template.Core.Models;
using Acr.UserDialogs;
using Login_Page_Template.Core.ViewModels;



namespace Login_Page_Template.Core.Services
{
    public class FirebaseHelper
    {

        public FirebaseClient firebase = new FirebaseClient("https://logintemplate-xavi-default-rtdb.firebaseio.com/");
        public FirebaseHelper firebaseHelper = new FirebaseHelper();
        public async Task AddPersona(string name, string apellidos, string email, string contrasenya)
        {

            await firebase
              .Child("Persons")
              .PostAsync(new Persona() {  Nombre = name, Apellidos = apellidos, Email = email, Contrasenya = contrasenya });
        }

      
        public async Task<List<Persona>> GetAllPersons()
        {

            return (await firebase
              .Child("Persons")
              .OnceAsync<Persona>()).Select(item => new Persona
              {
                  Nombre = item.Object.Nombre,
        
                  Apellidos = item.Object.Apellidos,
                  Email = item.Object.Email,
                  Contrasenya = item.Object.Contrasenya

              }).ToList();
        }

        private async void AddUser(string nombre, string apellidos, string email, string contrasenya )
        {
            await firebaseHelper.AddPersona(nombre, apellidos, email, contrasenya);

            UserDialogs.Instance.Alert("Success", "Person Added Successfully", "OK");
 

        }


    }
}
