using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub.IntefazForm
{
    public static class Validador
    {
        public static bool ValidarString(string stringParaAnalizar)
        {
            if (string.IsNullOrEmpty(stringParaAnalizar))
            {
                return false;
            }
            else if (stringParaAnalizar.All(x => char.IsLetter(x) || char.IsWhiteSpace(x) || char.IsPunctuation(x)))
            {
                return true;
            }

            return false;
        }

        public static bool ValidarStringEspecial(string stringParaAnalizar)
        {
            if (string.IsNullOrEmpty(stringParaAnalizar))
            {
                return false;
            }
            return true;
        }

        public static bool ValidarStringNumerico(string numero)
        {     
            if (string.IsNullOrEmpty(numero))
            {
                return false;
            }

            if (numero.All(char.IsDigit))
            {
                return true;
            }
            else return false;
        }

        public static bool ValidarFecha(string fecha, out DateTime fechaValidada)
        {
            return DateTime.TryParseExact(fecha, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaValidada);
        }

        public static bool ValidarDni(string numeroString)
        {                    
            //Comprobamos si el DNI tiene 8 o 7 digitos
            if (numeroString.Length < 7 || numeroString.Length > 8)
            {
                //No es un DNI Valido
                return false;
            }

            if (numeroString.All(char.IsDigit))
            {
                return true;
            }
            else return false;        
        }

        public static bool ValidarPrecio (string precio, out double numeroPrecio)
        {
            return double.TryParse(precio, out numeroPrecio);
        }


        public static bool ValidarStringNumericoMinMax (string numeroString, int min, int max)
        {
            bool pudeConvertir;
            bool retorno = true; 
            int numero;
            pudeConvertir = Int32.TryParse(numeroString, out numero);
            if (pudeConvertir)
            {
                if (numero < min || numero > max)
                {
                    retorno = false;
                }
            } else retorno = false;



            return retorno;


        }
    }
}
