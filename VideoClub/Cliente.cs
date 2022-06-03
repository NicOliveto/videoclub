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


        public Cliente(string idCliente, string fechaAlta, bool cliActivo, string host, string usuario,
            string nombre, string apellido, string direccion, int dni, string telefono, string mail, DateTime fechaNac )
            : base (nombre, apellido, direccion, dni, telefono, mail, fechaNac)
            
            
            {
            _idCliente = idCliente;
            _fechaAlta = fechaAlta;
            _cliActivo = cliActivo;
            _host = host;
            _usuario = usuario;

             }


       

    }






    }
