using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using Domain.Entities;
using Domain.Queries;
using ServerDomain;

namespace MainServer
{
    public class MyServer : IQueryHandler
    {
        private TcpListener server = new TcpListener(Dns.Resolve("127.0.0.1").AddressList[0], 1488);

        static void Main()
        {
            Candidate fCandidate = new Candidate(), sCandidate = new Candidate();
            fCandidate.FirstName = "PUPS";
            sCandidate.FirstName = "Pikachu";

            RepositoryService.Repository.SaveCandidate(fCandidate);
            RepositoryService.Repository.SaveCandidate(sCandidate);

            var server = new MyServer();
        }

        public MyServer()
        {
            server.Start();
            while (true)
            {
                using (var myClient = server.AcceptTcpClient())
                {
                    NetworkStream clientStream = myClient.GetStream();

                    var formatter = new BinaryFormatter();
                    var query = formatter.Deserialize(clientStream) as GetCandidateByNameQuery;

                    var result = Process(query);

                    formatter.Serialize(clientStream, result ?? (object)new NullQueryResult());
                }
            }
        }

        public object Process(IQuery query)
        {
            return query.Process(this);
        }

        public Candidate Process(GetCandidateByNameQuery query)
        {
            return RepositoryService.Repository.GetCandidateByName(query.Name);
        }
    }
}
