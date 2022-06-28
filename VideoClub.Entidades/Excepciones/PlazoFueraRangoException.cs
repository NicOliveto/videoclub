using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub.Entidades.Excepciones
{
    public class PlazoFueraRangoException : Exception
    {
        public PlazoFueraRangoException() : base ("La cantidad de días de alquiler no puede ser menor a 1, ni mayor a 15") { }
    }
}
