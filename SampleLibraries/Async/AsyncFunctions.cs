using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleLibraries.Async
{
    public class AsyncFunctions
    {
        public void Main()
        {
            var sw = new Stopwatch();
            sw.Start();

            DoByParent();

            sw.Stop();
            TimeSpan span = sw.Elapsed;
            Console.WriteLine(span.TotalMilliseconds);

        }

        public async Task DoByParent()
        {
            //Thread.Sleep(1000);
            await Task.WhenAll(DoByChild(), DoByChild());

            //var a = DoByChild();
            //var b = DoByChild();
            //await Task.WhenAll(a, b);
        }

        public async Task DoByChild()
        {
            //DoSync();
            await DoAsync();
        }

        public async Task DoAsync()
        {
            await Task.Delay(1000);
            Console.WriteLine("do async");
        }

        public void DoSync()
        {
            Task.Delay(1000).Wait();
            Console.WriteLine("do sync");
        }
    }
}
