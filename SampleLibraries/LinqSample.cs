using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibraries
{
    public class LinqSample
    {
        public void DoSomething()
        {
            var arr = new string[] { "a", "bb", "ccc" };
            var a = arr.Any(s => s == "a");
            var w = arr.Where(s => s.Length >= 2);
            var wType = w.GetType() ;
            var s2 = arr.Select(s => s + s);
        }
    }
}
