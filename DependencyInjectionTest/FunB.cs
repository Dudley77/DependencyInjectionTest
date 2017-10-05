using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionTest
{
    public class FunB : IFun
    {
        public virtual int Age
        {
            get
            {
                return 2000;
            }
        }

        public virtual string Name
        {
            get
            {
                return "Methusulah";
            }
        }
    }
}
