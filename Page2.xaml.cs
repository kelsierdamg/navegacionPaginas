using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace navegacionPaginas
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private async void BackBtn(object sender, EventArgs e)
        {
            // Volver a la página anterior
            await Navigation.PopAsync();
        }
    }
}
