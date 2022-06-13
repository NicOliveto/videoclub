using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.Specialized;
using VideoClub.AccesoDatos.Utilidades;
using VideoClub.Entidades;

namespace VideoClub.AccesoDatos
{
    public class ClienteDatos
    {
        public List<Cliente> TraerClientes()
        {
            string json2 = WebHelper.Get("cliente/881188"); // trae un texto en formato json de una web
            List<Cliente> resultado = MapList(json2);
            return resultado;
        }

        public Cliente TraerClientePorTelefono(string telefono)
        {
            string json = WebHelper.Get("cliente/" + telefono + "/telefono"); // trae un texto en formato json de una web
            Cliente resultado = MapObj(json);
            return resultado;
        }

        private List<Cliente> MapList(string json)
        {
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(json); // deserializacion
            return lst;
        }

        private Cliente MapObj(string json)
        {
            Cliente obj = JsonConvert.DeserializeObject<Cliente>(json); // deserializacion
            return obj;
        }

        public TransactionResult Insertar(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente); //serializacion -> json
            string json = WebHelper.Post("cliente", obj);
            TransactionResult rslt = JsonConvert.DeserializeObject<TransactionResult>(json);
            return rslt;
        }

        public TransactionResult Actualizar(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);
            string json = WebHelper.Put("cliente", obj);
            TransactionResult rslt = JsonConvert.DeserializeObject<TransactionResult>(json);
            return rslt;
        }

        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", cliente.IdCliente);
            n.Add("nombre", cliente.Nombre);
            n.Add("apellido", cliente.Apellido);
            n.Add("direccion", cliente.Direccion);
            n.Add("telefono", cliente.Telefono);
            n.Add("email", cliente.Mail);
            n.Add("dni", cliente.DNI.ToString());
            n.Add("activo", cliente.CliActivo.ToString());
            n.Add("fechaNacimiento", cliente.FechaNac.ToString("yyyy-MM-dd"));
            n.Add("usuario", "881188"); // Nro regsitro FCE-UBA Wepfer
            return n;
        }
    }
}
