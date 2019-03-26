using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3CSharp.domain
{
    class ZborDTO
    {
        public TimeSpan Ora { get; set; }
        public int Locuri { get; set; }

        public ZborDTO(TimeSpan ora, int locuri)
        {
            this.Ora = ora;
            this.Locuri = locuri;
        }

        public override String ToString()
        {
            return "Zbor{" +
                    "ora=" + Ora +
                    ", locuri=" + Locuri + '\'' +              
                    '}';
        }
    }
}
