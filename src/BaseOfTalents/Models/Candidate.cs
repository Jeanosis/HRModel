using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseOfTalents.Models
{
    public class Candidate : BaseEntity
    {
        public Candidate()
        {
            dob = DateTime.Now;
        }
        #region Properties

        public virtual String FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                LastEditTime = DateTime.Now;
            }
        }

        public virtual String MiddleName
        {
            get { return middleName; }
            set
            {
                middleName = value;
                LastEditTime = DateTime.Now;
            }
        }

        public virtual String LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                LastEditTime = DateTime.Now;
            }
        }
        
        public virtual DateTime DoB
        {
            get { return dob; }
            set
            {
                dob = value;
                LastEditTime = DateTime.Now;
            }
        }

        public virtual Byte[] Photo
        {
            get { return photo; }
            set
            {
                photo = value;
                LastEditTime = DateTime.Now;
            }
        }

        public virtual bool RelocationAgreement
        {
            get { return relocationAgreement; }
            set
            {
                relocationAgreement = value;
                LastEditTime = DateTime.Now;
            }
        }

        public virtual String About
        {
            get { return about; }
            set
            {
                about = value;
                LastEditTime = DateTime.Now;
            }
        }

        public virtual Dictionary<Vacancy, List<StageInfo>> VacanciesProgress
        {
            get { return vacanciesProgress; }
            set
            {
                vacanciesProgress = value;
                LastEditTime = DateTime.Now;
            }
        }

        #endregion
        #region Variables

        private String firstName;
        private String middleName;
        private String lastName;
        private DateTime dob;
        private Byte[] photo;
        private bool relocationAgreement;
        private String about;
        private Dictionary<Vacancy, List<StageInfo>> vacanciesProgress;

        #endregion
    }
}