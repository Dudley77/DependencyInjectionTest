using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionTest
{
    public class Program
    {
  
        public static IFun fun { get; set; }
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.LoadConfiguration();
            fun = container.Resolve<IFun>();

            //Testttttttt
            //Test2
            Console.WriteLine("Name: " + fun.Name.ToString());
            Console.WriteLine("Age: " + fun.Age.ToString());
            Console.ReadLine();

            
        }

    }

}
