using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class OracleConnection : DbConnection
    {

        public OracleConnection(string s) : base(s)
        {

        }
        public override void OpenDbConnection()
        { 
          // if connection string eleje nem tartalmaz 'SQL', akkor nem jo

          // if valamennyi timespan, akkor kiirja h nem sikerult
        }

        public override void CloseDbConnection()
        {
            
        }
    }
}
