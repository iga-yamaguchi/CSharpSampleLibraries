using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibraries.Iterator
{
    public class Month
    {
        public IEnumerable<Week> Weeks { get; set; }

        public Month(IEnumerable<Week> weeks)
        {
            this.Weeks = weeks;
        }
    }
}
