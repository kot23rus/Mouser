using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mouser
{
    public class SearchResponse
    {
        public List<Models.ErrorEntity> Errors { get; set; }
        public Models.SearchResponse SearchResults { get; set; }
    }
}
