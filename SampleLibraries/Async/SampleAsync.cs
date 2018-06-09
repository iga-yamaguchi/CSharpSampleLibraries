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
        public async Task<string> GetSingleAsync()
        {
            var result = await GetStringAsync();
            return $"結果={result}";
        }

public async Task<string> GetMultiAsync()
{
    var task1 = GetStringAsync();
    var task2 = GetStringAsync();
    var task3 = GetStringAsync();
    var task4 = GetIntAsync();

    var results = await Task.WhenAll(task1, task2, task3);

    return string.Join(",", results);
}

        private Task<int> GetIntAsync()
        {
            var task = Task<int>.Run(() =>
            {
                return 1;
            });
            return task;
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
