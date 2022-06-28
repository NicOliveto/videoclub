using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub.Entidades.Excepciones
{
    public class ClienteMenorEdadException : Exception
    {
        public ClienteMenorEdadException() : base("No pueden asociarse clientes menores de edad") { }
    }
}
