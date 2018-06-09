using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibraries.CodeContracts
{
    public class User
    {
        public virtual void DoSomthing(int number)
        {
            return;
        }
    }

    public class RegisteredUser : User
    {
        public override void DoSomthing(int number)
        {
            //if(number > 0)
            //{
            //    throw new ArgumentException();
            //}
            Contract.Requires<ArgumentException>(number > 0);
        }
    }
}
