using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystemWPF
{
    class Queen : Bee
    {
        public Queen() : base("Queen")
        { }
        public const float EGGS_PER_SHIFT = 0.45f;
        public const float HONEY_PER_UNASSIGNED_WORKER = 0.5f;
        public string StatusReport { get; private set; }
        public override float CostPerShift { get { return 2.15f; } }
    }
}
