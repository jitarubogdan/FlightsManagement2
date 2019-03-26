using lab3CSharp.domain;
using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3CSharp.repository
{
    class AngajatRepository : IAngajatRepository<String, String>
    {
        private static readonly ILog log = LogManager.GetLogger("AngajatRepository");

        IDictionary<String, string> props;

        public AngajatRepository(IDictionary<String, string> props)
        {
            this.props = props;
        }

        public Angajat isAngajat(string user, string password)
        {
            IDbConnection con = DBUtils.getConnection(props);

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select * from Angajati where User=@user and Password=@password";
                IDbDataParameter paramId = comm.CreateParameter();
                paramId.ParameterName = "@user";
                paramId.Value = user;
                comm.Parameters.Add(paramId);
                IDbDataParameter paramPassword = comm.CreateParameter();
                paramPassword.ParameterName = "@password";
                paramPassword.Value = password;
                comm.Parameters.Add(paramPassword);

                using (var dataR = comm.ExecuteReader())
                {
                    if (dataR.Read())
                    {
               
                        String User2 = dataR.GetString(0);
                        String Password2 = dataR.GetString(1);


                        Angajat a = new Angajat(User2, Password2);
                        //log.InfoFormat("Exiting findOne with value {0}", c);
                        return a;
                    }
                }
            }
            //log.InfoFormat("Exiting findOne with value {0}", null);
            return null;

        }
    }
}
