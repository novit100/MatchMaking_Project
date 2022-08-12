using BL;
using DP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriesToDELETE
{
    class Program
    {
        static void Main(string[] args)
        {   
            IBL bl = BLFactory.GetBL();
            //didnt work:
            Parent parent = bl.AddparentToDAL("גד", "סגל", "", Gender.Male, Origin.Afghan, -2);
            Console.WriteLine(parent);
            Console.ReadKey();
        }
    }
}
