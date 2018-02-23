using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSCS
{
    public class StaticticsRow
    {
        public int MachineNumber { get; set; }
        public int WorkingTime { get; set; }
        public int PlannedStopingsTime { get; set; }
        public int UnplannedStopingsTime { get; set; }
        public int UnplannedStoppings { get; set; }
        public int PlannedStopping { get; set; }
        public float MTBF { get; set; }
    }
}
