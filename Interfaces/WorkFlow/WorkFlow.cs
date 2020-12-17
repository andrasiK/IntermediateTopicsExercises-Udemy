using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class WorkFlow
    {
     //   public string Name { get; set; }

        public List<IActivity> Activities { get; }

        public WorkFlow(List<IActivity> activites)
        {
            Activities = activites;
        }

    }
}
