using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub
{
    public class Cliente : Persona
    {
        protected string _idCliente;
        protected string _fechaAlta;
        protected bool _cliActivo;
        protected string _host;
        protected string _usuario;

        public Cliente(string nombre, string apellido, string direccion, int dni, string telefono, string mail, DateTime fechanac, 
            string idcliente, bool cliactivo, string host, string usuario)
        {
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _dni = dni;
            _telefono = telefono;
            _mail = mail;
            _fechaNac = fechanac;
            _idCliente = idcliente;
            _cliActivo = cliactivo;
            _host = host;
            _usuario = usuario;
        }

        internal override string Display()
        {
            return string.Format("{0} ({1})", this._nombre, this._apellido, this._idCliente);
        }
    }
}
