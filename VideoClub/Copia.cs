using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub
{
    public class Copia
    {
        private int _idPelicula;
        private string _observaciones;
        private double _precio;
        private DateTime _fechaAlta;
        private int _idCopia;


        public int IdPelicula { get { return _idPelicula; } set { _idPelicula = value; } }
        public string Observaciones { get { return _observaciones; } set { _observaciones = value; } }
        
        public double Precio { get { return _precio; } set { _precio = value; } }
        public DateTime FechaAlta { get { return _fechaAlta; } set { }  }
        public int IdCopia { get { return _idCopia; } set { _idCopia = value; } } 





    }
}
