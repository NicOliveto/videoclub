using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub.IntefazForm
{
    public static class Auxiliar
    {
        public static int ConvertirAInteger(string numeroString)
        {
            int numero; 
            bool pudeConvertir;
            pudeConvertir = Int32.TryParse(numeroString, out numero);                        
            return numero;
        }

        public static int ConvertirDNI(string numeroString)
        {
            int numero = -1;                   
            //Intentamos convertir los números del DNI a integer
            bool pudeConvertir = int.TryParse(numeroString, out int numeroDni);
            if (!pudeConvertir)
            {
                //No se pudo convertir los números a formato númerico
                return numero;
            }
            numero = numeroDni;
            //DNI Valido
            return numero;
        }



    }
}
