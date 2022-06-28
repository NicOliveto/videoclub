using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClub.Entidades;

namespace VideoClub.Negocio
{
    public static class ReglasNegocio
    {
        // Verifico si el cliente existe, usando el DNI del nuevo cliente.
        public static bool ClienteExiste(int DNINuevoCliente, List<Cliente> lstClientes)
        {
            foreach (Cliente cliente in lstClientes)
            {
                if (cliente.DNI == DNINuevoCliente)               
                    return true;
            }
            return false;
        }

        public static bool PeliculaExiste(string tituloNuevaPelicua, List<Pelicula> lstPeliculas)
        {
            foreach (Pelicula pelicula in lstPeliculas)
            {
                if (pelicula.Titulo == tituloNuevaPelicua)
                    return true;
            }

            return false;
        }

        public static bool PlazoFueraRango(int plazo)
        {
            if (plazo < 1 || plazo > 15)
                return true;
            else return false;
        }

        public static bool ClienteMenorEdad(DateTime fechaNac)
        {
            int age = 0;
            age = DateTime.Now.Year - fechaNac.Year;
            if (DateTime.Now.DayOfYear < fechaNac.DayOfYear)
                age = age - 1;

            if (age < 18)
                return true;
            else return false;
        }
    }
}
