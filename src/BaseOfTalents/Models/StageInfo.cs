using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseOfTalents.Models
{
    public class StageInfo : BaseEntity
    {
        public StageInfo()
        {
            date = DateTime.Now;
        }
        #region Properties

        public virtual DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                LastEditTime = DateTime.Now;
            }
        }

        public virtual String Comment
        {
            get { return comment; }
            set
            {
                comment = value;
                LastEditTime = DateTime.Now;
            }
        }

        #endregion
        #region Variables

        private DateTime date;
        private String comment;

        #endregion
    }
}