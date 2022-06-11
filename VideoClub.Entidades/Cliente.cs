using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub
{
    public class Cliente : Persona
    {
        private string _idCliente;
        private string _fechaAlta;
        private bool _cliActivo;
        private string _host;
        private string _usuario;

        public string Id { get => _idCliente; set => _idCliente = value; }
        public string FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public bool CliActivo { get => _cliActivo; set => _cliActivo = value; }
        public string Host { get => _host; set => _host = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }

        internal override string Display()
        {
            return string.Format("{0} ({1})", this.Nombre, this.Apellido, this.Id);
        }
    }
}
