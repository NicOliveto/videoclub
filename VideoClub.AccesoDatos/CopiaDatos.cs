using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.Specialized;
using VideoClub.AccesoDatos.Utilidades;
using VideoClub.Entidades;

namespace VideoClub.AccesoDatos
{
    public class CopiaDatos
    {
        public List<Copia> TraerCopias()
        {
            string json = WebHelper.Get("VideoClub/Copia");
            List<Copia> resultado = MapList(json);
            return resultado;
        }

        public Copia TraerCopiaPorId(int idcopia)
        {
            string json = WebHelper.Get("VideoClub/Copia/" + idcopia.ToString());
            Copia resultado = MapObj(json);
            return resultado;
        }

        private List<Copia> MapList(string json)
        {
            List<Copia> lst = JsonConvert.DeserializeObject<List<Copia>>(json); // deserializacion
            return lst;
        }

        private Copia MapObj(string json)
        {
            Copia obj = JsonConvert.DeserializeObject<Copia>(json); // deserializacion
            return obj;
        }

        public TransactionResult Insertar(Copia copia)
        {
            NameValueCollection obj = ReverseMap(copia); //serializacion -> json
            string json = WebHelper.Post("VideoClub/Copia", obj);
            TransactionResult rslt = JsonConvert.DeserializeObject<TransactionResult>(json);
            return rslt;
        }

        private NameValueCollection ReverseMap(Copia copia)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("idPelicula", copia.IdPelicula.ToString());
            n.Add("observaciones", copia.Observaciones);
            n.Add("precio", copia.Precio.ToString());
            n.Add("fechaAlta", copia.FechaAlta.ToString());
            n.Add("id", copia.IdCopia.ToString());
            return n;
        }
    }
}
