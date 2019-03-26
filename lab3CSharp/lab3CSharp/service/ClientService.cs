using lab3CSharp.domain;
using lab3CSharp.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3CSharp.service
{
    class ClientService
    {
        private IClientRepository repo;

        public ClientService(IClientRepository repo)
        {
            this.repo = repo;
        }

        public void save(Client c) {
            repo.save(c);
        }

        public IEnumerable<Client> findAll()
        {
            return repo.findAll();
        }
    }
}
