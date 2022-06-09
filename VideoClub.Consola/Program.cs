using EjercicioClientes.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var datos = new VideoClubDatos();
            var result = datos.TraerTodos();




        }
    }
}
