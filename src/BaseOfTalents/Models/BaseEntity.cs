using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseOfTalents.Models
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            LastEditTime = DateTime.Now;
        }
        #region Properties

        public virtual Guid Id { get; protected set; }
        public virtual DateTime LastEditTime { get; protected set; }

        #endregion
    }
}