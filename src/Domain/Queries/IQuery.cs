using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Queries
{
    public interface IQuery
    {
        Guid ClientId { get; set; }
        object Process(IQueryHandler handler);
    }
}
