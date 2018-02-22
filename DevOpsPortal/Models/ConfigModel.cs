using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DevOpsPortal.Models
{

        public class Settings
        {
            public static Settings GetSettings()
            {
                return JsonConvert.DeserializeObject<Settings>(File.ReadAllText(@"C:\Users\jcollins\Dropbox\Jenkon\scripts\deploy\exampleDeployConfig.json"));
            }
            public List<Customer> customers { get; set; }
        }
        public class Customer
        {
            public string name { get; set; }
            public List<Environment> environments { get; set; }

        }

        public class WebServer
        {
            public string name { get; set; }
            public string ip { get; set; }
            public string hostname { get; set; }
        }

        public class SqlServer
        {
            public string ip { get; set; }
            public string hostname { get; set; }
            public string dbName { get; set; }
            public string backups { get; set; }

        }

        public class RteServer
        {
            public string ip { get; set; }
            public string hostname { get; set; }
            public string rteServiceName { get; set; }
            public string rteDir { get; set; }
            public string rteDrive { get; set; }

        }

        public class RedisServer
        {
            public string ip { get; set; }
            public string hostname { get; set; }
        }

        public class ReportsServer
        {
            public string ip { get; set; }
            public string hostname { get; set; }
            public string reportURL { get; set; }
            public string dbName { get; set; }
            public string reportFolder { get; set; }

        }

        public class Environment
        {
            public string name { get; set; }
            public List<WebServer> webservers { get; set; }
            public SqlServer sql { get; set; }
            public RteServer rte { get; set; }
            public RedisServer redis { get; set; }
            public ReportsServer reports { get; set; }
            public string appDrive { get; set; }
            public string appDir { get; set; }
            public string pkgDir { get; set; }
            public string custPrefix { get; set; }
            public string url { get; set; }
            public string siteBAKSDir { get; set; }
        }

        


}
