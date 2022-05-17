using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Entities;

namespace WebApi.Services
{
    public interface IClientService
    {
       IEnumerable<Client> GetAll();
    }
    public class ClientService : IClientService
    {
        private List<Client> _clients = new List<Client>
        {
            new Client { Id = 1, FirstName = "Test", LastName = "User", CPF = "487.546.884-08"  }
        };

        public IEnumerable<Client> GetAll()
        {
            return _clients;
        }
    }
}
