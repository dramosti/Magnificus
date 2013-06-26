using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HLP.Comum.Services.Interface
{
    public interface IConfiguraBaseService
    {
        DataTable GetServer();

        DataSet GetDatabases(string connectionString);

        bool TestConnection(string connectionString);

        string GetConnectionString();
    }
}
