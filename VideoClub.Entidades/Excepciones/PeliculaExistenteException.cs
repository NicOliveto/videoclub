using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub.Entidades.Excepciones
{
    public class PeliculaExistenteException : Exception
    {
        public PeliculaExistenteException() : base("El titulo de la pelicula duplicado, ya existe en la base de datos.") { }
    }
}
