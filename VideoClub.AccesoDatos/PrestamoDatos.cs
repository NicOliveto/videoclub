using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.Specialized;
using VideoClub.AccesoDatos.Utilidades;
using VideoClub.Entidades;

namespace VideoClub.AccesoDatos
{
    public class PrestamoDatos
    {
        public List<Prestamo> TraerPrestamos()
        {
            string json = WebHelper.Get("VideoClub/Prestamos");
            List<Prestamo> resultado = MapList(json);
            return resultado;
        }

        private List<Prestamo> MapList(string json)
        {
            List<Prestamo> lst = JsonConvert.DeserializeObject<List<Prestamo>>(json); // deserializacion
            return lst;
        }

        public TransactionResult Insertar(Prestamo prestamo)
        {
            NameValueCollection obj = ReverseMap(prestamo); //serializacion -> json
            string json = WebHelper.Post("VideoClub/Prestamos", obj);
            TransactionResult rslt = JsonConvert.DeserializeObject<TransactionResult>(json);
            return rslt;
        }

        private NameValueCollection ReverseMap(Prestamo prestamo)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("idCliente", prestamo.IdCliente.ToString());
            n.Add("idCopia", prestamo.IdCopia.ToString());
            n.Add("plazo", prestamo.Plazo.ToString());
            n.Add("abierto", prestamo.Abierto.ToString());
            n.Add("fechaPrestamo", prestamo.FechaPrestamo.ToString());
            n.Add("fechaDevolucionTentativa", prestamo.FechaDevolucionTentativa.ToString());
            n.Add("fechaDevolucionReal", prestamo.FechaDevolucionReal.ToString());
            n.Add("id", prestamo.IdPrestamo.ToString());
            return n;
        }
    }
}
