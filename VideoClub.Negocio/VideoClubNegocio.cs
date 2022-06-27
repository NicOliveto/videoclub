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
        public List<Cliente> ConsultarClientes()
        {
            List<Cliente> clientes = _clienteDatos.TraerClientes();
            return clientes;
        }

        public List<Copia> ConsultarCopias()
        {
            List<Copia> copias = _copiaDatos.TraerCopias();
            return copias;
        }

        public List<Pelicula> ConsultarPeliculas()
        {
            List<Pelicula> peliculas = _peliculaDatos.TraerPeliculas();
            return peliculas;
        }

        public List<Prestamo> ConsultarPrestamos()
        {
            List<Prestamo> prestamos = _prestamoDatos.TraerPrestamos();
            return prestamos;
        }

        public Cliente ConsultarClientePorIdCliente(int idCliente)
        {
            foreach (Cliente cliente in ConsultarClientes())
            {
                if (idCliente.ToString() == cliente.Id)
                    return cliente;
            }

            return null;
        }

        public Copia ConsultarCopiaPorIdCopia(int idCopia)
        {
            foreach (Copia copia in ConsultarCopias())
            {
                if (idCopia == copia.Id)
                    return copia;
            }

            return null;
        }

        public List<Copia> ConsultarCopiasPorIdPelicula(int idPelicula)
        {
            List<Copia> copias = _copiaDatos.TraerCopiaPorIdPelicula(idPelicula);
            return copias;
        }

        public Pelicula ConsultarPeliculaPorIdPelicula(int idPelicula)
        {
            Pelicula pelicula = _peliculaDatos.TraerPeliculaPorIdPelicula(idPelicula);
            return pelicula;
        }

        public Prestamo ConsultarPrestamoPorIdPrestamo(int idPrestamo)
        {
            foreach (Prestamo prestamo in ConsultarPrestamos())
            {
                if (prestamo.IdPrestamo == idPrestamo)
                    return prestamo;
            }
            return null;
        }

        public List<Prestamo> ConsultarPrestamosPorIdPelicula(int idPelicula)
        {
            List<Prestamo> prestamos = ConsultarPrestamos();
            List<Prestamo> resultado = new List<Prestamo>();

            foreach (Copia copia in ConsultarCopiasPorIdPelicula(idPelicula))
            {
                List<Prestamo> lst = prestamos.FindAll(x => x.IdCopia == copia.Id && x.Abierto == true);
                resultado.AddRange(lst);
            }

            return resultado;
        }

        public List<Prestamo> ConsultarPrestamosPorCondicion(bool condicion)
        {
            List<Prestamo> prestamos = new List<Prestamo>();
            foreach (Prestamo prestamo in ConsultarPrestamos())
            {
                if (prestamo.Abierto == condicion)
                {
                    prestamos.Add(prestamo);
                }
            }

            return prestamos;
        }

        public List<Prestamo> ConsultarPrestamosPorIdCliente(int idcliente)
        {
            List<Prestamo> resultado = new List<Prestamo>();
            foreach (Prestamo prestamo in ConsultarPrestamos())
            {
                if (idcliente == prestamo.IdCliente)
                {
                    resultado.Add(prestamo);
                }
            }

            return resultado;
        }


        /*********Metodos de insertado de datos**********/
        public void AltaCliente(string nombre, string apellido, int dni, string email, 
            string direccion, string telefono, DateTime fechaNac)
        {
            Cliente cliente = new Cliente(nombre, apellido, direccion, dni, telefono, email, fechaNac);

            TransactionResult transaction = _clienteDatos.Insertar(cliente);

            if (!transaction.isOk)
                throw new Exception(transaction.error);
        }

        public void AltaPrestamo(int idCliente, int idCopia, int plazo, bool abierto, DateTime fechaPrestamo, DateTime fechaDevTentativa, 
            DateTime fechaDevReal)
        {
            Prestamo prestamo = new Prestamo(idCliente, idCopia, plazo, abierto, fechaPrestamo, fechaDevTentativa, fechaDevReal);
            TransactionResult transaction = _prestamoDatos.Insertar(prestamo);

            if (!transaction.isOk)
                throw new Exception(transaction.error);
        }

        public void AltaPelicula(int anio, int duracion, string titulo, string director, string productora, string genero, int idPelicula)
        {
            Pelicula pelicula = new Pelicula(anio, duracion, titulo, director, productora, genero, idPelicula);
            TransactionResult transaction = _peliculaDatos.Insertar(pelicula);

            if (!transaction.isOk)
                throw new Exception(transaction.error);
        }

        public void AltaCopia(int idPelicula, string observaciones, double precio, DateTime fechaAlta, int idCopia)
        {
            Copia copia = new Copia(idPelicula, observaciones, precio, fechaAlta, idCopia);
            TransactionResult transaction = _copiaDatos.Insertar(copia);

            if (!transaction.isOk)
                throw new Exception(transaction.error);
        }
    }
}
