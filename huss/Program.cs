using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huss
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Savings savings=new Savings("Monika",50000,123456);
            savings.deposit(70000);
          
            savings.withdraw(30000);

            savings.displayInfo();
        }
    }
}
