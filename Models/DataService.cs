using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSummit.Models
{
    public class DataService: ServiceBase
    {
        public string Process(string data)
        {
            int Resultado = 0;
            bool esNumerico = Int32.TryParse(data, out Resultado);
            if (esNumerico)
            {
                NumericService numericService = new NumericService();
                return numericService.Procces(Resultado);
            }
            else
            {
                AlphaNumericService alphaNumericService = new AlphaNumericService();
                return alphaNumericService.Procces(data);
            }
        }
    }
}
