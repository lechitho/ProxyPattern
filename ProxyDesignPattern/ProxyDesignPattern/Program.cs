using ProxyDesignPattern.Model;
using ProxyDesignPattern.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client passing employee with Role Developer to folderproxy");
            Employee emp1 = new Employee("John", "Developer");
            SharedFolderProxy folderProxy1 = new SharedFolderProxy(emp1);
            folderProxy1.PerformRWOperations();
            Console.WriteLine();
            Console.WriteLine("Client passing employee with Role Manager to folderproxy");
            Employee emp2 = new Employee("Mary", "Manager");
            SharedFolderProxy folderProxy2 = new SharedFolderProxy(emp2);
            folderProxy2.PerformRWOperations();
        }
    }
}
