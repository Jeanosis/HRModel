using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Repositories;
using ServerDomain.Repositories;

namespace ServerDomain
{
    public static class RepositoryService
    {
        private static IMainRepository repository = new MainRepository();

        public static IMainRepository Repository
        {
            get { return repository; }
        }
    }
}
