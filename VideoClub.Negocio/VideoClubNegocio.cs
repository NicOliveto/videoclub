using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClub.AccesoDatos;
using VideoClub.Entidades;

namespace VideoClub.Negocio
{
    public class VideoClubNegocio
    {
        private ClienteDatos _clienteDatos;
        private CopiaDatos _copiaDatos;
        private PeliculaDatos _peliculaDatos;
        private PrestamoDatos _prestamoDatos;

        public VideoClubNegocio() 
        {
            _clienteDatos = new ClienteDatos();
            _copiaDatos = new CopiaDatos();
            _peliculaDatos = new PeliculaDatos();
            _prestamoDatos = new PrestamoDatos();
        }


        /*********Metodos de consultas de datos**********/
        public List<Cliente> GetListClientes()
        {
            List<Cliente> clientes = _clienteDatos.TraerClientes();
            return clientes;
        }

        public List<Prestamo> GetListPrestamosPorIdPelicula(int idpelicula)
        {
            List<Copia> copias = _copiaDatos.TraerCopiaPorIdPelicula(idpelicula);
            List<Prestamo> prestamos = _prestamoDatos.TraerPrestamos();
            List<Prestamo> resultado = new List<Prestamo>();

            foreach (Copia copia in copias)
            {
                List<Prestamo> lst = prestamos.FindAll(x => x.IdCopia == copia.IdCopia && x.Abierto == true);
                resultado.AddRange(lst);
            }

            return resultado;
        }

        public Pelicula GetPeliculaPorIdPelicula(int idpelicula)
        {
            Pelicula pelicula = _peliculaDatos.TraerPeliculaPorIdPelicula(idpelicula);
            return pelicula;
        }

        public List<Copia> GetListCopiasPorIdPelicula(int idpelicula)
        {
            List<Copia> copias = _copiaDatos.TraerCopiaPorIdPelicula(idpelicula);
            return copias;
        }


        /*********Metodos de reportes**********/


        /*********Metodos de insertado de datos**********/
    }
}
