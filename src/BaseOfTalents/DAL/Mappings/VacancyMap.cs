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
    public class VacancyMap : ClassMapping<Vacancy>
    {
        public VacancyMap()
        {
            Id(vacancy => vacancy.Id, mapper => mapper.Generator(Generators.Guid));
            Property(vacancy => vacancy.LastEditTime);
            Property(vacancy => vacancy.StartDate);
            Property(vacancy => vacancy.EndDate);
            Property(vacancy => vacancy.Name, mapper => mapper.Length(255));
            Property(vacancy => vacancy.RequiredSkills, mapper => mapper.Length(255));
            Property(vacancy => vacancy.RequiredSkills, mapper => mapper.Length(255));
            Property(vacancy => vacancy.Comment, mapper => mapper.Length(255));
        }
    }
}