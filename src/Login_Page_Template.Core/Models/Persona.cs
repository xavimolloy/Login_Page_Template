using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Login_Page_Template;
using Login_Page_Template.Core.ViewModels;

namespace Login_Page_Template.Core.Models
{
     public class Persona : INotifyPropertyChanged
    {
        
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Contrasenya { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void onPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    
}
