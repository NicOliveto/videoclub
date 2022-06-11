using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub
{
    public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected string _direccion;
        protected int _dni;
        protected string _telefono;
        protected string _mail;
        protected DateTime _fechaNac;

        public string Nombre { get => _nombre ; set => _nombre = value; }
        public string Apellido { get => _apellido ; set => _apellido = value; } 
        public string Direccion { get => _direccion ; set => _direccion = value; }
        public int DNI { get => _dni ; set => _dni = value; }   
        public string Telefono { get => _telefono ; set => _telefono = value;}
        public string Mail { get => _mail ; set => _mail = value; }
        public DateTime FechaNac { get => _fechaNac ; set => _fechaNac = value; }

        internal abstract string Display();

        public override string ToString()
        {
            return this.Display();
        }
    }
}
