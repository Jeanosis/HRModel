using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseOfTalents.DAL.Repositories;

namespace BaseOfTalents.DAL
{
    public class RepositoryService
    {
        private static IMainRepository repository = new MainRepository();

        public static IMainRepository Repository
        {
            get { return repository; }
        }
    }
}