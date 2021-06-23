using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Mouser
{
    /// <summary>
    /// Процессор обработки запросов
    /// </summary>
    public class Request
    {
        /// <summary>
        /// Точка подключения
        /// </summary>
        public string MouserURL = "https://api.mouser.com";

        public string Version = "1";

        /// <summary>
        /// Ключ запроса
        /// </summary>
        public string key = string.Empty;
        /// <summary>
        /// Адрес API
        /// </summary>
        public string apiURL = string.Empty;
        
        /// <summary>
        /// Метод запроса
        /// </summary>
        protected string Metod = "POST";

        public void Execute()
        {
            var request = WebRequest.Create(GetURL());
            request.ContentType = "application/json";
            request.Method = "POST";
            var json = GetRequestParams();
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(GetRequestParams());
            }
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                LoadResponse(reader.ReadToEnd());
            }
        }

        protected string GetURL()
        {
            return string.Format("{0}/api/v{1}/{2}?apiKey={3}", MouserURL, Version, apiURL, key);
        }

        protected virtual string GetRequestParams()
        {
            return string.Empty;
        }

        protected virtual void LoadResponse(string json)
        {

        }
        
        
        
    }
}
