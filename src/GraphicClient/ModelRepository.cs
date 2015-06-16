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
using Domain.Repositories;

namespace GraphicClient
{
    public class ModelRepository : IMainRepository
    {
        public void SaveCandidate(Candidate candidate)
        {
            
        }

        public Candidate GetCandidateByName(string name)
        {
            var query = new GetCandidateByNameQuery(name);

            using (var client = new TcpClient("127.0.0.1", 1488))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(client.GetStream(), query);

                var result = formatter.Deserialize(client.GetStream());

                return (Candidate)(result is NullQueryResult ? null : result);
            }
        }

        public List<Candidate> GetAllCandidates()
        {
            return new List<Candidate>();
        }

        private bool disposed = false;
    }
}
