using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseOfTalents.Models
{
    public class VacancyListEntry
    {
        public VacancyListEntry()
        {
            this.Name = "";
            this.StartDate = DateTime.Now;
            this.EndDate = DateTime.Now;
        }

        public VacancyListEntry(Vacancy vacancy)
        {
            if (vacancy == null)
            {
                throw new ArgumentNullException("vacancy");
            }

            this.Name = vacancy.Name;
            this.StartDate = vacancy.StartDate;
            this.EndDate = vacancy.EndDate;
        }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
