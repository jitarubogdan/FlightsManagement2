using lab3CSharp.repository;
using lab3CSharp.service;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3CSharp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //XmlConfigurator.Configure(new System.IO.FileInfo(args[0]));
            //Console.WriteLine("Configuration Settings for agentie {0}", GetConnectionStringByName("agentie"));
            IDictionary<String, string> props = new SortedList<String, String>();
            props.Add("ConnectionString", GetConnectionStringByName("agentie"));


            IAngajatRepository<string, string> repoA = new AngajatRepository(props);
            AngajatService srvA = new AngajatService(repoA);

            IClientRepository repoC = new ClientRepository(props);
            ClientService srvC = new ClientService(repoC);

            IZborRepository repoZ = new ZborRepository(props);
            ZborService srvZ = new ZborService(repoZ);

            IBiletRepository repoB = new BiletRepository(props);
            BiletService srvB = new BiletService(repoB,repoC,repoZ);

            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form2 form2 = new Form2();
            form2.setService(srvA, srvC, srvZ, srvB);
            Application.Run(form2);
        }

        static string GetConnectionStringByName(string name)
        {
            // Assume failure.
            string returnValue = null;

            // Look for the name in the connectionStrings section.
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];

            // If found, return the connection string.
            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }
    }
}
