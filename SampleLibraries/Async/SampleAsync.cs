using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibraries.Async
{
    public class SampleAsync
    {
        public async Task<string> GetString()
        {
            var result = await GetStringAsync();
            return $"結果={result}";
        }

        private Task<string> GetStringAsync()
        {
            var task = Task<string>.Run(() =>
            {
                return "async!";
            });
            return task;
        }
    }
}
