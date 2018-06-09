#define construct
using SampleLibraries.Async;
using SampleLibraries.CodeContracts;
using SampleLibraries.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibraries
{
    class Program
    {
        static void Main(string[] args)
        {
#if iterator
            var calendar = new Calendar();
            var cal = calendar.Get();
            //var weeks = calendar.GetWeeks();
            Console.WriteLine(cal);

            foreach(var month in cal)
            {
                foreach(var week in month.Weeks)
                {
                    foreach(var date in week.DateTimes)
                    {
                        Console.WriteLine(date.ToString());
                    }
                }
            }

#elif contaractS
            var user = new RegisteredUser();
            user.DoSomthing(1);
#elif generics
            new GenericsSample().Exec();
#elif async
            new AsyncFunctions().Main();

#elif gettersetter

            //var people = new People();
            //people.FirstName = "Taro";
            //people.LastName = "Tanaka";
            //Console.WriteLine(people.FullName);
#elif construct
            var people = new People(age: 5, birthday: DateTime.Now)
            {
                FirstName = "Taro",
                LastName = "Tanaka"
            };

var child = new Child1("test", 1);
Console.WriteLine(child.GetContent());
#elif linq
            new LinqSample().DoSomething();
#endif
        }
    }
}
