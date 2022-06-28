using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub.Entidades.Excepciones
{
    public class ClienteExistenteException : Exception
    {
        public ClienteExistenteException() : base("El dni del cliente ya existe en la base de datos.") { }
    }
}
