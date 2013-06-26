using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using HLP.Comum.Services.Interface;
using HLP.Comum.Repository.Interfaces;
using System.Data;

namespace HLP.Comum.Services.Implementation
{
    public class ConfiguraBaseService : IConfiguraBaseService
    {
        [Inject]
        public IConfiguraBaseRepository configuraBaseRepository { get; set; }

        public DataTable GetServer()
        {
            return configuraBaseRepository.GetServer();
        }


        public DataSet GetDatabases(string connectionString)
        {
            return configuraBaseRepository.GetDatabases(connectionString);
        }


        public bool TestConnection(string connectionString)
        {
            return configuraBaseRepository.TestConnection(connectionString);
        }


        public string GetConnectionString()
        {
            return configuraBaseRepository.GetConnectionString();
        }
    }
}
