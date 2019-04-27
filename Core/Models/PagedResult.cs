using System.Collections.Generic;
using System.Linq;

namespace Core.Models
{
    public class PagedResult<T> : PagedResultBase
    {
        public IEnumerable<T> Results { get; set; }

        public PagedResult()
        {
            Results = Enumerable.Empty<T>();
        }
    }
}
