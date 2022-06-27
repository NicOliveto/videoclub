using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub.IntefazForm
{
    public static class Auxiliar
    {
        public static int ConvertirAInteger(int minimo, int maximo, string numeroString)
        {
            int numero = minimo - 1;
            bool pudeConvertir;

            pudeConvertir = Int32.TryParse(numeroString, out numero);

            if (!(pudeConvertir))
            {
                numero = -1;
                return numero;
            }

            if (numero < minimo || numero > maximo)
            {
                numero = -1;
                return numero;
            }

            return numero;
        }





    }
}
