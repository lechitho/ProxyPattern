using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern.RealSubject
{
    public class SharedFolder : ISharedFolder
    {
        public void PerformRWOperations()
        {
            Console.WriteLine("Performing Read Write operation on the Shared Folder");
        }
    }
}
