using lab3CSharp.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3CSharp.repository
{
    interface IClientRepository : ICrudRepository<int, Client>
    {
        Client findClientByNameAndAdresa(String nume, String adresa);
    }
}
