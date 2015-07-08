using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using Domain.Entities;

namespace ServerDomain.Mappings
{
    public class CandidateMap : ClassMapping<Candidate>
    {
        public CandidateMap()
        {
            Id(x => x.Id, m => m.Generator(Generators.Guid));
            Property(x => x.FirstName, m => m.Length(255));
            Property(x => x.LastEditTime);
        }
    }
}
