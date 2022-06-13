using System;
using System.Collections.Generic;
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




    }
}