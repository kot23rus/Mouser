using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mouser
{
    public class SearchByKeyword:Request
    {
        
        public Models.SearchByKeyword SearchByKeywordRequest { get; set; }

        public SearchByKeyword()
        {
            apiURL = "/search/keyword";
        }
        /// <summary>
        /// Ответ на запрос
        /// </summary>
        public SearchResponse Response;

        protected override string GetRequestParams()
        {
            JsonSerializerOptions options = new()
            {
                WriteIndented = false,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
            };
            return JsonSerializer.Serialize(this, typeof(SearchByKeyword), options);
        }

        protected override void LoadResponse(string json)
        {
            Response = JsonSerializer.Deserialize<SearchResponse>(json);
        }
    }
}
