using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class WorkFlowEngine
    {
        WorkFlow WorkFlow { get; }

        public WorkFlowEngine(WorkFlow workFlow)
        {
            WorkFlow = workFlow;
        }
        public void Run()
        {
            foreach (var activity in WorkFlow.Activities)
            {
                activity.Execute();
            }
        }
    }
}
