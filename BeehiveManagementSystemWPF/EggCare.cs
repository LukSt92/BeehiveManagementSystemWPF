﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystemWPF
{
    class EggCare : Bee
    {
        public EggCare(Queen queen) : base("Egg Care") 
        {
            this.queen = queen;
        }
        public const float CARE_PROGRESS_PER_SHIFT = 0.15f;
        public override float CostPerShift { get { return 1.35f; } }
        private Queen queen;
        protected override void DoJob()
        {
            queen.CareForEggs(CARE_PROGRESS_PER_SHIFT);
        }
    }
}
