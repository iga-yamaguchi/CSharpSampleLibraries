using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibraries
{
    public class GenericsSample
    {
        public void Exec()
        {
            // エラーにならない
            var list = new List<Parent>();
            list.Add(new Child());
            list.Add(new Child());

            // エラーになる
            //List<Child> children = new List<Child>();
            //List<Parent> parents = children;
        }
    }

    public class Parent { }

    public class Child : Parent { }
}
