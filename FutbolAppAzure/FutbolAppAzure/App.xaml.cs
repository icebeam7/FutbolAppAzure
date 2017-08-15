using FutbolAppAzure.Servicios;
using Xamarin.Forms;

namespace FutbolAppAzure
{
    public partial class App : Application
    {
        public static ServicioAzure ServicioAzure = new ServicioAzure();

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Paginas.PaginaListaEquipos());
        }
    }
}
