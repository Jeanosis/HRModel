using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Serializable]
    public class Candidate : IEntity
    {
        private String firstName;
 
        public Candidate() { }

        public virtual Guid Id { get; set; }
        public virtual String FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                LastEditTime = DateTime.Now;
            }
        }


        public virtual DateTime LastEditTime { get; protected set; }
    }
}
