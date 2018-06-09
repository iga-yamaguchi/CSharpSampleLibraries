using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibraries.Iterator
{
    public class Week
    {
        public IEnumerable<DateTime> DateTimes { get; set; }

        public Week(IEnumerable<DateTime> dateTimes)
        {
            this.DateTimes = dateTimes;
        }
    }
}
