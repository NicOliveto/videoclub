using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VideoClub.Entidades
{

    public class Prestamo
    {
        private int _idCliente;
        private int _idCopia;
        private int _plazo;
        private bool _abierto;
        private DateTime _fechaPrestamo;
        private DateTime _fechaDevolucionTentativa;
        private DateTime _fechaDevolucionReal;
        private int _idPrestamo;

        public Prestamo(int idCliente, int idCopia, int plazo, bool abierto, DateTime fechaPrestamo, DateTime fechaDevolucionTentativa, DateTime fechaDevolucionReal)
        {
            _idCliente = idCliente;
            _idCopia = idCopia;
            _plazo = plazo;
            _abierto = abierto;
            _fechaPrestamo = fechaPrestamo;
            _fechaDevolucionTentativa = fechaDevolucionTentativa;
            _fechaDevolucionReal = fechaDevolucionReal;
            //_idPrestamo = idPrestamo;
        }

        public int IdCliente { get { return _idCliente; } set { _idCliente = value; } }
        public int IdCopia { get { return _idCopia; } set { _idCopia = value; } }
        public int Plazo { get { return _plazo; } set { _plazo = value; } }
        public bool Abierto { get { return _abierto; } set { _abierto = value; } }
        public DateTime FechaPrestamo { get { return _fechaPrestamo; } set { _fechaPrestamo = value; } }
        public DateTime FechaDevolucionTentativa { get { return _fechaDevolucionTentativa; } set { _fechaDevolucionTentativa = value; } }
        public DateTime FechaDevolucionReal { get { return _fechaDevolucionReal; } set { _fechaDevolucionReal = value; } }
        public int Id { get { return _idPrestamo; } set { _idPrestamo = value; } }
        public string ComboDisplay { get => $"  ID Prestamo: {this._idPrestamo}  ID Cliente: {this._idCliente}  ID Copia: {this._idCopia}   "; }

        public string Display(bool condicion)
        {
            if (condicion)
            {
                return " Fecha del prestamo: " + this._fechaPrestamo + "\n Fecha devolución tentativa:" + this._fechaDevolucionTentativa;
            } 
            else
            {
                return " Fecha del prestamo: " + this._fechaPrestamo + "\n Fecha devolución tentativa: " + this._fechaDevolucionTentativa + "\n Fecha de devolución real: " + this._fechaDevolucionReal;
            }
        }

        public override string ToString()
        {
            //return " Plazo: " + this._plazo + "\n Abierto: " + this._abierto ? "SI" : "NO" + "\n Fecha prestamo: " + this._fechaPrestamo + "\n Fecha devolución tentativa:" + this._fechaDevolucionTentativa;
            return string.Format(" Plazo: {0}\n Abierto: {1}\n Fecha Prestamo: {2}\n Fecha devolucion tentativa: {3}\n",
                this._plazo, this._abierto ? "SI" : "NO", this._fechaPrestamo, this._fechaDevolucionTentativa);
        }
    }
}