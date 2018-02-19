using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSCS
{
    public class Stopping
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int MachineNumber { get; set; }
        public int Reason { get; set; }
        public int StoppingTime { get; set; }
        public int Shift { get; set; }
    }


}
