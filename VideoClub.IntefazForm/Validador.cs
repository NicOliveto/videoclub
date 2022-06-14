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
            else if (stringParaAnalizar.All(char.IsLetter))
            {
                return true;
            }

            return false;
        }

        public static bool ValidarFecha(string fecha, out DateTime fechaValidada)
        {
            return DateTime.TryParseExact(fecha, "yyyy-mm-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaValidada);
        }
    }
}