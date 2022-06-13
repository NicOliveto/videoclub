using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub.Entidades
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

        public Cliente()
        {
        }

        public string Id { get { return _idCliente; } set { _idCliente = value; } }
        public string FechaAlta { get { return _fechaAlta; } set { _fechaAlta = value; } }
        public bool CliActivo { get { return _cliActivo; } set { _cliActivo = value;} }
        public string Host { get { return _host; } set { _host = value; } }
        public string Usuario { get { return _usuario; } set { _usuario = value; } }
        public string Email { get  { return _mail; } set { _mail = value; } }
        public string ComboDisplay { get => $" /{this._idCliente}/  {this._nombre} {this._apellido}   "; }
   
        internal override string Display()
        {
            return "Id cliente: " + this._idCliente + "\n Apellido:" + this.Apellido + "\n Nombre:" + this.Nombre + "\n Direccion" + this.Direccion +
                "\n DNI:" + this._dni + "\n Teléfono: " + this._telefono + "\n Mail:" + this.Mail + "\n Fecha nacimiento" + this.FechaNac;
        }
    }
}
