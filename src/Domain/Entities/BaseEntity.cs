using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Serializable]
    public class BaseEntity
    {
        public virtual Guid Id { get; protected set; }
        public virtual DateTime LastEditTime { get; protected set; } 
    }
}
