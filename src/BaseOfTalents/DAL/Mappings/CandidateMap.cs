using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using BaseOfTalents.Models;

namespace BaseOfTalents.DAL.Mappings
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