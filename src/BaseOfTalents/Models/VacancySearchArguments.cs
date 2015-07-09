using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseOfTalents.Models
{
    public class VacancySearchArguments
    {
        public DateTime? MaxStartDate { get; set; }
        
        public DateTime? MinStartDate { get; set; }

        public DateTime? MaxEndDate { get; set; }

        public DateTime? MinEndDate { get; set; }

        public string Name { get; set; }

        public static VacancySearchArguments Empty()
        {
            return new VacancySearchArguments();
        }
    }
}