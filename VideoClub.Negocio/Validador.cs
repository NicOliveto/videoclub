using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClub.Entidades;

namespace VideoClub.Negocio
{
    public static class Validador
    {


        // Verifico si el cliente existe, usando el DNI del nuevo cliente.
        public static bool ClienteNoExiste(int DNINuevoCliente, List<Cliente> lstClientes)
        {
            

            foreach (Cliente cliente in lstClientes)
            {
                if (cliente.DNI == DNINuevoCliente)               
                    return false;
                              

            }
            return true;
        }

        public static bool PeliculaNoExiste(string tituloNuevaPelicua, List<Pelicula> lstPeliculas)
        {
            foreach (Pelicula pelicula in lstPeliculas)
            {
                if (pelicula.Titulo == tituloNuevaPelicua)
                    return false;
            }

            return true;
        }



    }
}
