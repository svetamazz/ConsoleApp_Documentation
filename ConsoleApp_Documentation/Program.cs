using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Documentation
{
    /// <summary>
    /// Main Class Of Application
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starting Point
        /// </summary>
        /// <param name="args">Console parameters</param>
        static void Main(string[] args)
        {
           var logic = new Logic();
            bool res = logic.checkYear(2000, 3);
            //
        }
    }
}
