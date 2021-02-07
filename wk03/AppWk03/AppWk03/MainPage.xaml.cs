using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppWk03
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            dtp.Date = DateTime.Now;
            dtp.MinimumDate = new DateTime(1990,1,1);
            dtp.MaximumDate = new DateTime(2030,12,31);

            editor.Completed += Editor_Completed;
            editor.TextChanged += Editor_TextChanged;

        }

        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Editor_Completed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            /* 
             *  Esto recibe
             *  DisplayAlert("string de el titulo del mensaje", "Texto de la alerta", "titulo de accion al hacerlick");
            */
            DisplayAlert("Alerta", "TEXT CHANGED", "Ok");
        }
        // En el code behind se programa todo lo que ocupemos que la herramienta haga o ejecute
        // de acuerdo a la accion que se ejecute.

    }
}
