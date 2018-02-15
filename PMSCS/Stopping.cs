using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSCS
{
    public class Stopping
    {
        int Id { get; set; }
        DateTime Date { get; set; }
        int MachineNumber { get; set; }
        int Reason { get; set; }
        int StoppingTime { get; set; }
        int Shift { get; set; }
    }


}
