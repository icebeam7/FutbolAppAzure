using FutbolAppAzure.Clases;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FutbolAppAzure.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaEquipo : ContentPage
    {
        Equipo Equipo;

        public PaginaEquipo(Equipo equipo)
        {
            InitializeComponent();
            Equipo = equipo;
            this.BindingContext = equipo;
        }

        private async void Guardar_Clicked(object sender, EventArgs e)
        {
            if (Equipo.Id != "")
                await App.ServicioAzure.ModificarEquipo(Equipo);
            else
                await App.ServicioAzure.AgregarEquipo(Equipo);

            await DisplayAlert("FutbolApp", "Equipo registrado con éxito", "OK");
        }

        private async void Eliminar_Clicked(object sender, EventArgs e)
        {
            if (await DisplayAlert("Eliminar", "¿Deseas eliminar el equipo?", "Si", "No"))
                await App.ServicioAzure.EliminarEquipo(Equipo);

            await DisplayAlert("FutbolApp", "Equipo eliminado con éxito", "OK");
            await Navigation.PopAsync();
        }
    }
}
