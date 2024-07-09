using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystemWPF
{
    abstract class Bee : IWorker
    {
        public Bee(string job)
        {
            Job = job;
        }
        public abstract float CostPerShift { get; }
        public string Job { get; private set; }
        public void WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift))
                DoJob();
        }
        protected abstract void DoJob();
    }
}
