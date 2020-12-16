using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class SqlConnection : DbConnection
    {

        public SqlConnection(string s) : base(s)
        {

        }
        public override void OpenDbConnection()
        {
            Console.WriteLine("SQL database connection opened");   
        }

        public override void CloseDbConnection()
        {
            Console.WriteLine("SQL database connection closed");
        }
    }
}
