using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibraries
{
    public class People
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get => $"{FirstName}{LastName}";
        }

        public int Age
        {
            get;
            private set;
        }

        private readonly DateTime birthday;

        public People(int age, DateTime birthday)
        {
            this.Age = age;
            this.birthday = birthday;
        }
    }

public class Parent1
{

}

public class Child1 : Parent
{
    private readonly string str;

    private readonly int num;

    public Child1(string str, int num)
    {
        this.str = str;
        this.num = num;
    }

    public string GetContent()
    {
        return $"str = {str}, num = {num}";
    }
}
}
