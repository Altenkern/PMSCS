using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSCS
{
    public static class StaticClass
    {
        public static List<Stopping> StoppingsList;
        public static Dictionary<int, bool> erors;

        static StaticClass()
        {
            StoppingsList = new List<Stopping>();
            erors = new Dictionary<int, bool>();
            erors.Add(1, true);
            erors.Add(2, true);
            erors.Add(3, true);
            erors.Add(4, true);
            erors.Add(5, true);
            erors.Add(6, true);
            erors.Add(7, true);
            erors.Add(8, true);
            erors.Add(9, true);

            erors.Add(10, false);
            erors.Add(11, false);
            erors.Add(12, false);
            erors.Add(13, false);
            erors.Add(14, false);
            erors.Add(15, false);

            erors.Add(20, false);
            erors.Add(22, false);
            erors.Add(23, false);
            erors.Add(24, false);
            erors.Add(25, false);
            erors.Add(26, false);
            erors.Add(27, false);
            erors.Add(28, false);
            erors.Add(29, false);
            erors.Add(30, false);
            erors.Add(31, false);
            erors.Add(32, false);
            erors.Add(33, false);
            erors.Add(34, false);
            erors.Add(35, false);

            erors.Add(41, false);
            erors.Add(42, false);
            erors.Add(43, false);
            erors.Add(44, false);
            erors.Add(45, false);

            erors.Add(50, true);
            erors.Add(51, true);

            erors.Add(60, true);
            erors.Add(61, true);
            erors.Add(62, true);
            erors.Add(63, true);

            erors.Add(70, true);
            erors.Add(71, true);
            erors.Add(72, true);
            erors.Add(73, true);

            erors.Add(76, true);
            erors.Add(77, true);

            erors.Add(81, true);
            erors.Add(82, true);
            erors.Add(83, true);
            erors.Add(84, true);

        }
    }
}
