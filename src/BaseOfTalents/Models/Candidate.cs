using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseOfTalents.Models
{
    public class Candidate : BaseEntity
    {
        public Candidate() { }

        public virtual String FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                LastEditTime = DateTime.Now;
            }
        }

        private String firstName;
    }
}