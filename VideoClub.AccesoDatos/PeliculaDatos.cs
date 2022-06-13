using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.Specialized;
using VideoClub.AccesoDatos.Utilidades;
using VideoClub.Entidades;

namespace VideoClub.AccesoDatos
{
    public class PeliculaDatos
    {
        public List<Pelicula> TraerPeliculas()
        {
            string json = WebHelper.Get("VideoClub/Pelicula");
            List<Pelicula> resultado = MapList(json);
            return resultado;
        }

        public Pelicula TraerPeliculaPorIdPelicula(int idpelicula)
        {
            string json = WebHelper.Get("VideoClub/Pelicula/" + idpelicula.ToString());
            Pelicula resultado = MapObj(json);
            return resultado;
        }

        private List<Pelicula> MapList(string json)
        {
            List<Pelicula> lst = JsonConvert.DeserializeObject<List<Pelicula>>(json); // deserializacion
            return lst;
        }

        private Pelicula MapObj(string json)
        {
            Pelicula obj = JsonConvert.DeserializeObject<Pelicula>(json); // deserializacion
            return obj;
        }

        public TransactionResult Insertar(Pelicula pelicula)
        {
            NameValueCollection obj = ReverseMap(pelicula); //serializacion -> json
            string json = WebHelper.Post("VideoClub/Pelicula", obj);
            TransactionResult rslt = JsonConvert.DeserializeObject<TransactionResult>(json);
            return rslt;
        }

        private NameValueCollection ReverseMap(Pelicula pelicula)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("anio", pelicula.Anio.ToString());
            n.Add("duracion", pelicula.Duracion.ToString());
            n.Add("titulo", pelicula.Titulo);
            n.Add("director", pelicula.Director);
            n.Add("productora", pelicula.Productora);
            n.Add("genero", pelicula.Genero);
            n.Add("id", pelicula.IdPelicula.ToString());
            return n;
        }
    }
}
