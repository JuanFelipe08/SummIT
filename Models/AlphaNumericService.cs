using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSummit.Models
{
    public class AlphaNumericService: DataService
    {
        public string Procces(string valor)
        {
            if (Dictionary.Count <= 0)
            {
                Dictionary.Add("_", 0); Dictionary.Add("A", 1); Dictionary.Add("B", 2); Dictionary.Add("C", 3);
                Dictionary.Add("D", 4); Dictionary.Add("E", 5); Dictionary.Add("F", 6); Dictionary.Add("G", 7);
                Dictionary.Add("H", 8); Dictionary.Add("I", 9); Dictionary.Add("J", 10); Dictionary.Add("K", 11);
                Dictionary.Add("L", 12); Dictionary.Add("M", 13); Dictionary.Add("N", 14); Dictionary.Add("Ñ", 15);
                Dictionary.Add("O", 16); Dictionary.Add("P", 17); Dictionary.Add("Q", 18); Dictionary.Add("R", 19);
                Dictionary.Add("S", 20); Dictionary.Add("T", 21); Dictionary.Add("U", 22); Dictionary.Add("V", 23);
                Dictionary.Add("W", 24); Dictionary.Add("X", 25); Dictionary.Add("Y", 26); Dictionary.Add("Z", 27);
            }           

            char[] arr = valor.ToUpper().ToCharArray();
            string texto = "";
            foreach (char c in arr)
            {
                if (c != ' ')
                {
                    int value = Dictionary[c.ToString()];
                    texto += value + "-";
                }
                else
                {
                    texto += " ";
                }
            }
            return "El texto en numero es: " + texto;
        }
    }
}
