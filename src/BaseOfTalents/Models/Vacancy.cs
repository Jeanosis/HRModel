using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseOfTalents.Models
{
    public class Vacancy : BaseEntity
    {
        public Vacancy()
        { 
            StartDate = DateTime.Today;
            EndDate = DateTime.Today.AddDays(7);
        }

        #region Properties

        public virtual string Name
        {
            get { return name; }
            set 
            {
                name = value;
                LastEditTime = DateTime.Now;
            }
        }

        public virtual DateTime StartDate
        {
            get { return startDate; }
            set 
            {
                startDate = value;
                LastEditTime = DateTime.Now;
            }
        }

        public virtual DateTime EndDate
        {
            get { return endDate; }
            set
            {
                endDate = value;
                LastEditTime = DateTime.Now;
            }
        }

        public virtual string RequiredSkills
        {
            get { return requiredSkills; }
            set
            {
                requiredSkills = value;
                LastEditTime = DateTime.Now;
            }
        }

        public virtual string Description
        {
            get { return description; }
            set
            {
                description = value;
                LastEditTime = DateTime.Now;
            }
        }

        public virtual string Comment
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

        private string name;
        private DateTime startDate;
        private DateTime endDate;
        private string requiredSkills;
        private string description;
        private string comment;

        #endregion
    }
}