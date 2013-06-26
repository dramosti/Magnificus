using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HLP.Comum.Repository.Interfaces
{
    public interface IConfiguraBaseRepository
    {
        DataTable GetServer();

        DataSet GetDatabases(string connectionString);

        bool TestConnection(string connectionString);

        string GetConnectionString();
    }
}
