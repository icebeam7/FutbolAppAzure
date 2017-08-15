using Microsoft.WindowsAzure.MobileServices;
using FutbolAppAzure.Clases;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FutbolAppAzure.Servicios
{
    public class ServicioAzure
    {
        public MobileServiceClient Client;
        private IMobileServiceTable<Equipo> TablaEquipo;

        public ServicioAzure()
        {
            Client = new MobileServiceClient("http://futbolapp-luisb.azurewebsites.net/");
            TablaEquipo = Client.GetTable<Equipo>();
        }

        public async Task AgregarEquipo(Equipo equipo)
        {
            try
            {
                await TablaEquipo.InsertAsync(equipo);
            }
            catch (Exception ex)
            {

            }
        }


        public async Task ModificarEquipo(Equipo equipo)
        {
            try
            {
                await TablaEquipo.UpdateAsync(equipo);
            }
            catch (Exception ex)
            {

            }
        }

        public async Task EliminarEquipo(Equipo equipo)
        {
            try
            {
                await TablaEquipo.DeleteAsync(equipo);
            }
            catch (Exception ex)
            {

            }
        }

        public async Task<List<Equipo>> ObtenerEquipos()
        {
            return await TablaEquipo.OrderBy(x => x.Nombre).ToListAsync();
        }

        public async Task<Equipo> ObtenerEquipo(string id)
        {
            var equipo = TablaEquipo.Where(x => x.Id == id);

            if (equipo != null)
            {
                var list = await equipo.ToListAsync();
                return list.Count > 0 ? list[0] : null; ;
            }
            else
                return null;
        }
    }
}
