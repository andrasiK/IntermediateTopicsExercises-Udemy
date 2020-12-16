using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
{
    class DbCommand
    {
        public string Command { get; set; }
        public DbConnection Connection { get; set; }



        public DbCommand(string command, DbConnection connection)
        {
            Command = command;
            Connection = connection;
        }

        public void Execute()
        {
            Connection.OpenDbConnection();
            Console.WriteLine("Database command successfully executed");
            Connection.CloseDbConnection();
        }
    }
}
