using lab3CSharp.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3CSharp.repository
{
    interface IAngajatRepository<E, T>
    {
        Angajat isAngajat(E user, T password);
    }
}
