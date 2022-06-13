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

        public Cliente GetClienteByIdCliente(int idCliente)
        {
                                             
            foreach (Cliente cliente in GetListClientes())
            {
                if (idCliente.ToString() == cliente.Id)
                    return cliente;
            }

            return null;
        }


        /*********Metodos de reportes**********/




        /*********Metodos de insertado de datos**********/
        public void AltaCliente(string nombre, string apellido, int dni, string email, 
            string domicilio, string telefono, DateTime fnac)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = nombre;
            cliente.Apellido = apellido;
            cliente.DNI = dni;
            cliente.FechaNac = fnac;
            cliente.Mail = email;
            cliente.Direccion = domicilio;
            cliente.Telefono = telefono;

            TransactionResult transaction = _clienteDatos.Insertar(cliente);

            if (!transaction.isOk)
                throw new Exception(transaction.error);
        }

        public void AltaPrestamo(int idCliente, int idCopia, int plazo, bool abierto, DateTime fechaPrestamo, DateTime fechaDevTentativa, 
            DateTime fechaDevReal, int idPrestamo)
        {
            Prestamo prestamo = new Prestamo(idCliente, idCopia, plazo, abierto, fechaPrestamo, fechaDevTentativa, fechaDevReal, idPrestamo);
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
