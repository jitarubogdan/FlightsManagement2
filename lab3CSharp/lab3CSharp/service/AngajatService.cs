using lab3CSharp.domain;
using lab3CSharp.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3CSharp.service
{
    class AngajatService
    {
        private IAngajatRepository<String,String> repo;

        public AngajatService(IAngajatRepository<String,String> repo)
        {
            this.repo = repo;
        }

        public Angajat isAngajatService(String user, String password)
        {
            return repo.isAngajat(user, password);
        }
    }
}
