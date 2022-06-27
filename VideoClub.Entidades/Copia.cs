using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub.Entidades
{
    public class Copia
    {
        private int _idPelicula;
        private string _observaciones;
        private double _precio;
        private DateTime _fechaAlta;
        private int _idCopia;

        public Copia (int idPelicula, string observaciones, double precio, DateTime fechaAlta)
        {
            _idPelicula = idPelicula;
            _observaciones = observaciones; 
            _precio = precio;
            _fechaAlta = fechaAlta;
        }

        public int IdPelicula { get { return _idPelicula; } set { _idPelicula = value; } }
        public string Observaciones { get { return _observaciones; } set { _observaciones = value; } }
        public double Precio { get { return _precio; } set { _precio = value; } }
        public DateTime FechaAlta { get { return _fechaAlta; } set { }  }
        public int Id { get { return _idCopia; } set { _idCopia = value; } }
        public string ComboDisplay { get => $" Id Copia: ({this._idCopia}) Id Pelicula:  {this._idPelicula} "; }

        public override string ToString()
        {
            return "Observaciones: " + this._observaciones + "\n Precio: " + this._precio + "\n Fecha Alta: " + this._fechaAlta;
        }
    }
}
