using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3CSharp.domain
{
    class Angajat : HasId<String>
    {
        public String Id { get; set; }
        public String Password { get; set; }

        public Angajat(String Id, String Password)
        {
            this.Id = Id;
            this.Password = Password;
        }

        public override String ToString()
        {
            return "Angajat{" +
                    "user=" + Id +
                    ", password='" + Password + '\'' +
                    '}';
        }
    }
}
