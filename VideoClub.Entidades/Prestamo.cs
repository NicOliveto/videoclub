using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub
{
    internal class Prestamo
    {
        private int _idCliente;
        private int _idCopia;
        private int _plazo;
        private bool _abierto;
        private DateTime _fechaPrestamo;
        private DateTime _fechaDevolucionTentativa;
        private DateTime _fechaDevolucionReal;
        private int _idPrestamo;

        public Prestamo(int idCliente, int idCopia, int plazo, bool abierto, DateTime fechaPrestamo, DateTime fechaDevolucionTentativa, DateTime fechaDevolucionReal, int idPrestamo)
        {
            _idCliente = idCliente;
            _idCopia = idCopia;
            _plazo = plazo;
            _abierto = abierto;
            _fechaPrestamo = fechaPrestamo;
            _fechaDevolucionTentativa = fechaDevolucionTentativa;
            _fechaDevolucionReal = fechaDevolucionReal;
            _idPrestamo = idPrestamo;
        }
    }
}
