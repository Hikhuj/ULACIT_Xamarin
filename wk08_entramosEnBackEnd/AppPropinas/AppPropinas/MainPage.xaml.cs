using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppPropinas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            var total = (decimal.Parse(txtTotal.Text));

            var propina = (decimal.Parse(txtPropina.Text));

            var noPersonas = (decimal.Parse(txtNoPersonas.Text));

            var totalPropina = ((total * propina) / 100);

            lblPropina.Detail = totalPropina.ToString("C");

            lblTotal.Detail = (totalPropina + total).ToString("C");

            lblPropinaPorPersona.Detail = (totalPropina / noPersonas).ToString("C");

            lblTotalPorPersona.Detail = ((totalPropina + total) / noPersonas).ToString("C");
        }
    }
}
