using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionTest
{
    public class FunA : IFun
    {
        public virtual int Age
        {
            get
            {
                return 1000;
            }
        }

        public virtual string Name
        {
            get
            {
                return "Old Bill";
            }
        }
    }
}
