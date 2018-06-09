using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibraries.Iterator
{
    public class Calendar
    {
        public IEnumerable<Month> Get()
        {
            var startDate = DateTime.Parse("2018/02/01 18:00:00");
            var endDate = DateTime.Parse("2019/03/02 18:00:00");


            int maxDayOfWeek = Enum.GetNames(typeof(DayOfWeek)).Length;

            var currentDate = startDate;
            var currentMonth = YearMonth(currentDate);

            var weeks = new List<Week>();
            var months = new List<Month>();

            while (currentDate < endDate)
            {
                var count = maxDayOfWeek - (int)currentDate.DayOfWeek;
                var dates = new List<DateTime>();

                for (var i = 0; i < count; i++)
                {
                    dates.Add(currentDate);
                    currentDate = currentDate.AddDays(1);

                    if (currentMonth != YearMonth(currentDate))
                    {
                        weeks.Add(new Week(dates));
                        //months.Add(new Month(weeks));
                        yield return new Month(weeks);
                        weeks = new List<Week>();
                        break;
                    }
                }

                if (currentMonth == YearMonth(currentDate))
                {
                    weeks.Add(new Week(dates));
                }
                else
                {
                    currentMonth = YearMonth(currentDate);
                }
            }

            //months.Add(new Month(weeks));

            //return months;
            yield return new Month(weeks);
        }

        private int YearMonth(DateTime date)
        {
            return date.Year * 100 + date.Month;
        }
    }
}
