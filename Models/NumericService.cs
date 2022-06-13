using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ApiSummit.Models
{
    public class NumericService: DataService
    {
        public string Procces(int Resultado)
        {
            var url = $"https://api.coinbase.com/v2/exchange-rates?currency=USD";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(responseBody);

                            decimal value = decimal.Parse(myDeserializedClass.data.rates.COP.Replace('.', ',')) * Resultado;

                            // Do something with responseBody
                            return "El valor en dolares es: " + value;
                            //Console.WriteLine(myDeserializedClass.data.rates.COP);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }
            return "Es Numerico";
        }
    }
}
