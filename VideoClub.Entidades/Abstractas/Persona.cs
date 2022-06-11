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

        internal abstract string Display();

        public override string ToString()
        {
            return this.Display();
        }
    }
}
