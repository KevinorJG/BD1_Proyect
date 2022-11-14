using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Commons.Processes
{
    public static class Generator
    {
        public static string GeneradorCodigo()
        {
            var characters = "0123456789";
            var Charsarr = new char[19];
            var random = new Random();
            int indice = 4;

            for (int i = 0; i < Charsarr.Length; i++)
            {                
                Charsarr[i] = characters[random.Next(characters.Length)];                                        
            }
            Charsarr[4] = '-';
            Charsarr[9] = '-';
            Charsarr[14] = '-';           

            return new String(Charsarr);
        }
    }
}
