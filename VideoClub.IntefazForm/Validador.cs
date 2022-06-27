﻿using System;
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

        public static bool ValidarStringEspecial(string direccion)
        {
            if (string.IsNullOrEmpty(direccion))
            {
                return false;
            }
            return true;
        }

        public static bool ValidarStringNumerico(string numero)
        {
            if (numero.All(char.IsDigit))
            {
                return true;
            }
            else return false;

        }

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

        public static bool ValidarFecha(string fecha, out DateTime fechaValidada)
        {
            return DateTime.TryParseExact(fecha, "yyyy-mm-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaValidada);
        }

        public static int ValidarDni(string numeroString)
        {
            int numero = -1;

            //Comprobamos si el DNI tiene 9 digitos
            if (numeroString.Length != 9)
            {
                //No es un DNI Valido
                return numero;
            }

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
