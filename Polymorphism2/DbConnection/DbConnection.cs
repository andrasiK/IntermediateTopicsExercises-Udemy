using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
{
    public abstract class DbConnection
    {
        // Properties
        public string ConnectionString { get; set; }
        public TimeSpan TimeOut { get; set; }

        // Constructor
        public DbConnection(string connectionString)
        {
            if (connectionString == null || connectionString == "")
            {
                throw new InvalidOperationException("Not valid connectionstring!");
            }
            ConnectionString = connectionString;
        }

        // Methods
        public abstract void OpenDbConnection();
        public abstract void CloseDbConnection();
    }
}
