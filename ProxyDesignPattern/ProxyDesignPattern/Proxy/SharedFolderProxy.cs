using ProxyDesignPattern.Model;
using ProxyDesignPattern.RealSubject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern.Proxy
{
    class SharedFolderProxy : ISharedFolder
    {
        private ISharedFolder folder;
        private Employee employee;
        public SharedFolderProxy(Employee emp)
        {
            employee = emp;
        }
        public void PerformRWOperations()
        {
            if (employee.Role.ToUpper() == "CEO" || employee.Role.ToUpper() == "MANAGER")
            {
                folder = new SharedFolder();
                Console.WriteLine("Shared Folder Proxy makes call to the RealFolder 'PerformRWOperations method'");
                folder.PerformRWOperations();
            }
            else
            {
                Console.WriteLine("Shared Folder proxy says 'You don't have permission to access this folder'");
            }
        }
    }
}
