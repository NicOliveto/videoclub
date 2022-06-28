using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VideoClub.IntefazForm
{
    public static class Validador
    {
        public static bool ValidarStringLetras(string stringParaAnalizar)
        {
            if (string.IsNullOrEmpty(stringParaAnalizar))
            {
                return false;
            }
            else if (stringParaAnalizar.All(x => char.IsLetter(x) || char.IsWhiteSpace(x)))
            {
                return true;
            }

            return false;
        }

        public static bool ValidarStringLetrasNumeros(string stringParaAnalizar)
        {
            if (string.IsNullOrEmpty(stringParaAnalizar))
            {
                return false;
            }
            else if (stringParaAnalizar.All(x => char.IsLetter(x) || char.IsWhiteSpace(x) || char.IsDigit(x)))
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

        public static bool ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public static bool ValidarTelefono(string numero)
        {
            if (string.IsNullOrEmpty(numero))
            {
                return false;
            }

            if (numero.Length != 10)
            {
                return false;
            }

            if (numero.All(char.IsDigit))
            {
                return true;
            }
            else return false;
        }
    }
}
